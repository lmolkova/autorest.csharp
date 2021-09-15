# Azure.AI.FormRecognizer
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require: $(this-folder)/../../readme.md
input-file:
    - https://github.com/Azure/azure-rest-api-specs/blob/7043b48f4be1fdd40757b9ef372b65f054daf48f/specification/cognitiveservices/data-plane/FormRecognizer/stable/v2.1/FormRecognizer.json
    - https://raw.githubusercontent.com/Azure/azure-rest-api-specs-pr/5fcc40f8557307a77303e906982651c925f7ff8e/specification/cognitiveservices/data-plane/FormRecognizer/preview/v3.0-preview.1/FormRecognizer.yml?token=AHUEAM3KLUFHDWCGEOUXLXLBITWCC
namespace: Azure.AI.FormRecognizer
```

## Create new client
```yaml
directive:
  - from: https://raw.githubusercontent.com/Azure/azure-rest-api-specs-pr/5fcc40f8557307a77303e906982651c925f7ff8e/specification/cognitiveservices/data-plane/FormRecognizer/preview/v3.0-preview.1/FormRecognizer.yml?token=AHUEAM3KLUFHDWCGEOUXLXLBITWCC
    where: $.paths..*[?(@.operationId !== undefined)]
    transform: >
      if (!$.operationId.includes("NewFormRecognizer_")) {
          $.operationId = "NewFormRecognizer_" + $.operationId;
      }
      $lib.log($.operationId)
```

## Rename duplicated types
``` yaml
directive:
  from: https://github.com/Azure/azure-rest-api-specs/blob/7043b48f4be1fdd40757b9ef372b65f054daf48f/specification/cognitiveservices/data-plane/FormRecognizer/stable/v2.1/FormRecognizer.json
  where: $.definitions.AnalyzeResult
  transform: >
    $["x-ms-client-name"] = "V2AnalyzeResult"
```

``` yaml
directive:
  from: https://raw.githubusercontent.com/Azure/azure-rest-api-specs-pr/5fcc40f8557307a77303e906982651c925f7ff8e/specification/cognitiveservices/data-plane/FormRecognizer/preview/v3.0-preview.1/FormRecognizer.yml?token=AHUEAM3KLUFHDWCGEOUXLXLBITWCC
  where: $.definitions.ModelInfo
  transform: >
    $["x-ms-client-name"] = "DocumentModelInfo"
```

``` yaml
directive:
  from: https://raw.githubusercontent.com/Azure/azure-rest-api-specs-pr/5fcc40f8557307a77303e906982651c925f7ff8e/specification/cognitiveservices/data-plane/FormRecognizer/preview/v3.0-preview.1/FormRecognizer.yml?token=AHUEAM3KLUFHDWCGEOUXLXLBITWCC
  where: $.definitions.ErrorResponse
  transform: >
    $["x-ms-client-name"] = "DocumentErrorResponse"
```
