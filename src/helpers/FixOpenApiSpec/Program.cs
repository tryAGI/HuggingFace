using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text
    .Replace("\"exclusiveMinimum\": 0", "\"exclusiveMinimum\": true")
    .Replace("\"exclusiveMinimum\": -2", "\"minimum\": -2")
    .Replace(@",
        ""discriminator"": {
          ""propertyName"": ""object""
        }", string.Empty)
    ;

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);
return;
