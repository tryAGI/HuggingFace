# Search Datasets

Search for datasets on the HuggingFace Hub using quicksearch and list results.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
using var client = new HuggingFaceClient(apiKey);

var response = await client.RepoSearch.CreateQuicksearchAsync(
    request: new Request45
    {
        Q = "sentiment analysis",
        Limit = 5,
        Exclude = [],
    });

Console.WriteLine($"Models: {response.ModelsCount}, Datasets: {response.DatasetsCount}, Spaces: {response.SpacesCount}");

foreach (var dataset in response.Datasets)
{
    Console.WriteLine($"  Dataset: {dataset.Id}");
}

foreach (var space in response.Spaces)
{
    Console.WriteLine($"  Space: {space.Id}");
}
```