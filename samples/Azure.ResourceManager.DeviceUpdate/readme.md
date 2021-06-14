# Azure.ResourceManager.DeviceUpdate
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
azure-arm: true
require: $(this-folder)/../../readme.md
input-file: $(this-folder)/sample.json
namespace: Azure.ResourceManager.DeviceUpdate
operation-group-to-resource-type:
   Operations: Microsoft.DeviceUpdate/operations
operation-group-to-resource:
   Operations: NonResource
directive:
  - rename-model:
      from: Operation
      to: RestApi
```
