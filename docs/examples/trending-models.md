# Trending Models

List recently trending models, datasets, and spaces on the HuggingFace Hub.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
var apiKey = GetApiKey();
using var client = new HuggingFaceClient(apiKey);

var response = await client.Models.GetTrendingAsync(limit: 5);

foreach (var item in response.RecentlyTrending)
{
    var id = item.Value1?.RepoData?.Id ?? item.Value2?.RepoData?.Id ?? item.Value3?.RepoData?.Id;
    var author = item.Value1?.RepoData?.Author ?? item.Value2?.RepoData?.Author ?? item.Value3?.RepoData?.Author;
    if (id is not null)
    {
        Console.WriteLine($"{id} by {author}");
    }
}
```