# Trending by Type

List trending items filtered by type (model, dataset, or space).

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
using var client = new HuggingFaceClient(apiKey);

var spaces = await client.Models.GetTrendingAsync(
    type: Type5.Space,
    limit: 3);

Console.WriteLine("Trending Spaces:");
foreach (var item in spaces.RecentlyTrending)
{
    var id = item.Value1?.RepoData?.Id ?? item.Value2?.RepoData?.Id ?? item.Value3?.RepoData?.Id;
    Console.WriteLine($"  {id}");
}
```