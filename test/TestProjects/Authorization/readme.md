# Accessibility

### AutoRest Configuration

> see https://aka.ms/autorest

```yaml

# azure-arm: true
# csharp: true
# library-name: Authorization
# namespace: Azure.ResourceManager.Identity.Authorization
# # require: https://raw.githubusercontent.com/Azure/azure-rest-api-specs/a416080c85111fbe4e0a483a1b99f1126ca6e97c/specification/authorization/resource-manager/readme.md
# require: https://raw.githubusercontent.com/dvbb/azure-rest-api-specs/f80d498bbca1726dd589e8ee471eac921e8cd1ca/specification/authorization/resource-manager/readme.md
# output-folder: Generated/
# clear-output-folder: true
# skip-csproj: true

require: $(this-folder)/../../../readme.md
input-file: $(this-folder)\authorization-AccessReviewCalls.json
security: AzureKey
security-header-name: Fake-Subscription-Key
```