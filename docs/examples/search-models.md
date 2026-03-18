# Search Models

Search for models, datasets, and spaces on the HuggingFace Hub using quicksearch.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
var apiKey = GetApiKey();
using var client = new HuggingFaceClient(apiKey);

var response = await client.RepoSearch.CreateQuicksearchAsync(
    request: new Request45
    {
        Q = "text-generation",
        Limit = 5,
        Exclude = [],
    });

Console.WriteLine($"Found {response.ModelsCount} models, {response.DatasetsCount} datasets");

foreach (var model in response.Models)
{
    Console.WriteLine($"  {model.Id} (weight={model.TrendingWeight:F2})");
}
```