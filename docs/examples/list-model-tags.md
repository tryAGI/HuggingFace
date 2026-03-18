# List Model Tags

List available model tags grouped by type from the HuggingFace Hub.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
var apiKey = GetApiKey();
using var client = new HuggingFaceClient(apiKey);

var tags = await client.Models.GetModelsTagsByTypeAsync();

foreach (var (tagType, tagList) in tags)
{
    Console.WriteLine($"{tagType}: {tagList.Count} tags");
}
```