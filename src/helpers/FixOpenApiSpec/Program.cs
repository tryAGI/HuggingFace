using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

yamlOrJson = yamlOrJson
    .Replace("\"exclusiveMinimum\": 0", "\"exclusiveMinimum\": true")
    .Replace("\"exclusiveMinimum\": -2", "\"minimum\": -2")
    .Replace(@",
        ""discriminator"": {
          ""propertyName"": ""object""
        }", string.Empty)
    ;

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
