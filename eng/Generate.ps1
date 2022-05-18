#Requires -Version 7.0
param($filter, [switch]$continue, [switch]$reset, [switch]$noBuild, [switch]$fast, [String[]]$Exclude = "SmokeTests", $parallel = 5)

Import-Module "$PSScriptRoot\Generation.psm1" -DisableNameChecking -Force;

$ErrorActionPreference = 'Stop'

# General configuration
$repoRoot = Resolve-Path (Join-Path $PSScriptRoot '..')

$swaggerDefinitions = @{};
$swaggerTestDefinitions = @{};

# Test server test configuration
$autoRestPluginProject = (Get-AutoRestProject)
$testServerDirectory = Join-Path $repoRoot 'test' 'TestServerProjects'
$sharedSource = Join-Path $repoRoot 'src' 'assets'
$configurationPath = Join-Path $repoRoot 'readme.md'
$testServerSwaggerPath = Join-Path $repoRoot 'node_modules' '@microsoft.azure' 'autorest.testserver' 'swagger'

function Add-Swagger ([string]$name, [string]$output, [string]$arguments) {
    $swaggerDefinitions[$name] = @{
        'projectName'=$name;
        'output'=$output;
        'arguments'=$arguments
    }
}

function Add-Swagger-Test ([string]$name, [string]$output, [string]$arguments) {
    $swaggerTestDefinitions[$name] = @{
        'projectName'=$name;
        'output'=$output;
        'arguments'=$arguments
    }
}

function Add-TestServer-Swagger ([string]$testName, [string]$projectSuffix, [string]$testServerDirectory, [string]$additionalArgs="") {
    $projectDirectory = Join-Path $testServerDirectory $testName
    $inputFile = Join-Path $testServerSwaggerPath "$testName.json"
    $inputReadme = Join-Path $projectDirectory "readme.md"
    Add-Swagger "$testName$projectSuffix" $projectDirectory "--require=$configurationPath --try-require=$inputReadme --input-file=$inputFile $additionalArgs"
}

$testNames = $null

if (!($Exclude -contains "TestServer"))
{
    foreach ($testName in $testNames)
    {
        Add-TestServer-Swagger $testName "" $testServerDirectory "--generation1-convenience-client"
    }
}

$llcArgs = "--data-plane=true --security=AzureKey --security-header-name=Fake-Subscription-Key"

$testServerLowLevelDirectory = Join-Path $repoRoot 'test' 'TestServerProjectsLowLevel'
$testNamesLowLevel = $null;

if (!($Exclude -contains "TestServerLowLevel"))
{
    foreach ($testName in $testNamesLowLevel)
    {
        Add-TestServer-Swagger $testName "-LowLevel" $testServerLowLevelDirectory $llcArgs
    }
}

function Add-Directory ([string]$testName, [string]$directory, [boolean]$forTest) {
    $readmeConfigurationPath = Join-Path $directory "readme.md"
    $testArguments = $null
    if (Test-Path $readmeConfigurationPath)
    {
        $testArguments = "--require=$readmeConfigurationPath"
    }
    else
    {
        $inputFile = Join-Path $directory "$testName.json"
        $testArguments ="--require=$configurationPath --input-file=$inputFile --generation1-convenience-client"
    }

    if ($forTest) {
        Add-Swagger-Test $testName $directory $testArguments
    }
    else {
        Add-Swagger $testName $directory $testArguments
    }
}

if (!($Exclude -contains "TestProjects"))
{
    # Local test projects
    $testSwaggerPath = Join-Path $repoRoot 'test' 'TestProjects'

    foreach ($directory in Get-ChildItem $testSwaggerPath -Directory)
    {
        $testName = $directory.Name
        $readmeConfigurationPath = Join-Path $directory "readme.md"
        $testArguments = $null
        $srcFolder = Join-Path $directory "src"
        $testsFolder = Join-Path $directory "tests"

        if ((Test-Path -Path $srcFolder) -And (Test-Path -Path $testsFolder)) {
            Add-Directory $testName $srcFolder $FALSE
            Add-Directory $testName $testsFolder $TRUE
            continue
        }
        if (Test-Path $readmeConfigurationPath)
        {
            $testArguments = "--require=$readmeConfigurationPath"
        }
        else
        {
            $inputFile = Join-Path $directory "$testName.json"
            $testArguments ="--require=$configurationPath --input-file=$inputFile --generation1-convenience-client"
        }

        Add-Swagger $testName $directory $testArguments
    }
}

# Sample configuration
$projectNames = $null

if (!($Exclude -contains "Samples"))
{
    foreach ($projectName in $projectNames)
    {
        $projectDirectory = Join-Path $repoRoot 'samples' $projectName
        $sampleConfigurationPath = Join-Path $projectDirectory 'readme.md'
        Add-Swagger $projectName $projectDirectory "--require=$sampleConfigurationPath"
    }
}

# Smoke tests
if (!($Exclude -contains "SmokeTests"))
{
    foreach ($input in Get-Content (Join-Path $PSScriptRoot "SmokeTestInputs.txt"))
    {
        if ($input -match "^(?<input>[^#].*?specification/(?<name>[\w-]+(/[\w-]+)+)/readme.md)(:(?<args>.*))?")
        {
            $input = $Matches["input"]
            $args = $Matches["args"]
            $projectName = $Matches["name"].Replace("/", "-");

            $projectDirectory = Join-Path $repoRoot 'samples' 'smoketests' $projectName

            Add-Swagger $projectName $projectDirectory "--generation1-convenience-client --require=$configurationPath $args $input"
        }
    }
}

# Sorting file names that include '-' and '.' is broken in powershell - https://github.com/PowerShell/PowerShell/issues/3425
# So map each to characters invalid for file system use '?' and '|', sort, and then map back
function Sort-FileSafe ($names) {
    return $names | % {$_.replace("-","?")} | % {$_.replace(".","|")} | Sort-Object |  % {$_.replace("?","-")} | % {$_.replace("|",".")}
}

$launchSettings = Join-Path $autoRestPluginProject 'Properties' 'launchSettings.json'
$settings = @{
    'profiles' = [ordered]@{}
};

foreach ($key in Sort-FileSafe ($swaggerDefinitions.Keys))
{
    $definition = $swaggerDefinitions[$key];
    $outputPath = Join-Path $definition.output "Generated"
    if ($key -eq "TypeSchemaMapping")
    {
        $outputPath = Join-Path $definition.output "SomeFolder" "Generated"
    }
    $outputPath = $outputPath.Replace($repoRoot, '$(SolutionDir)')

    $settings.profiles[$key] = [ordered]@{
        'commandName'='Project';
        'commandLineArgs'="--standalone $outputPath"
    }
}

$settings | ConvertTo-Json | Out-File $launchSettings

if ($reset -or $env:TF_BUILD)
{
    AutoRest-Reset;
}

if (!$noBuild)
{
    Invoke "dotnet build $autoRestPluginProject"
}

$keys = $swaggerDefinitions.Keys | Sort-Object;
if (![string]::IsNullOrWhiteSpace($filter))
{ 
    Write-Host "Using filter: $filter"
    if ($continue)
    {
        $keys = $keys.Where({$_ -match $filter},'SkipUntil') 
        Write-Host "Continuing with $keys"
    }
    else
    {
        $keys = $keys.Where({$_ -match $filter}) 
    }
}

$keys | %{ $swaggerDefinitions[$_] } | ForEach-Object -Parallel {
    Import-Module "$using:PSScriptRoot\Generation.psm1" -DisableNameChecking;
    Invoke-AutoRest $_.output $_.projectName $_.arguments $using:sharedSource $using:fast;
} -ThrottleLimit $parallel

$keys | %{ $swaggerTestDefinitions[$_] } | ForEach-Object -Parallel {
    if ($_.output -ne $null) {
        Import-Module "$using:PSScriptRoot\Generation.psm1" -DisableNameChecking;
        Invoke-AutoRest $_.output $_.projectName $_.arguments $using:sharedSource $using:fast;
    }
} -ThrottleLimit $parallel

