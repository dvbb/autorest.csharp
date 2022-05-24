# MgmtHierarchicalNonResource

## AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
azure-arm: true
require: $(this-folder)/../../../readme.md
input-file: $(this-folder)/CommunicationService.json
namespace: Azure.ResourceManager.Communication

directive:
  - rename-model:
      from: CommunicationServiceResource
      to: CommunicationService
  - rename-model:
      from: RegenerateKeyParameters
      to: RegenerateKeyOptions
  - rename-model:
      from: NameAvailabilityParameters
      to: NameAvailabilityOptions
  - rename-model:
      from: LinkNotificationHubParameters
      to: LinkNotificationHubOptions
```
