# Who Am I

Get the authenticated user's account information using the Hub API.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
var apiKey = GetApiKey();
using var client = new HuggingFaceClient(apiKey);

var response = await client.Auth.GetWhoamiV2Async();

Console.WriteLine($"User: {response}");
```