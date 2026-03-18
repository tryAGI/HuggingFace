# Search Papers

Search for papers and collections on the HuggingFace Hub.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
using var client = new HuggingFaceClient(apiKey);

var response = await client.RepoSearch.CreateQuicksearchAsync(
    request: new Request45
    {
        Q = "transformer attention",
        Limit = 5,
        Exclude = [],
    });

Console.WriteLine($"Papers: {response.PapersCount}, Collections: {response.CollectionsCount}");

foreach (var paper in response.Papers)
{
    Console.WriteLine($"  Paper: {paper.Id}");
}

foreach (var collection in response.Collections)
{
    Console.WriteLine($"  Collection: {collection.Title} - {collection.Description}");
}
```