# ServerReview
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
title: ServerReview
require: $(this-folder)/../../../readme.md
input-file: $(this-folder)/ServerReview.json
namespace: Azure.ServerReview
```

```yaml
directive:
- from: swagger-document
  where: $.definitions.Response
  transform: >
    $["x-csharp-usage"] = "model,input,output,converter";
    $["x-csharp-formats"] = "json";
```