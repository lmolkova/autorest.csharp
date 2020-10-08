# LiveVideoAnalytics
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
title: LiveVideoAnalytics
require: $(this-folder)/../../readme.md
public-clients: false
input-file: $(this-folder)/LiveVideoAnalytics.json
namespace: Azure.LiveVideoAnalytics
```
### Make generated models input only

``` yaml
directive:
  from: swagger-document
  where: $.definitions.*
  transform: >
    $["x-csharp-usage"] = "model,input,output";
    $["x-csharp-formats"] = "json";
```