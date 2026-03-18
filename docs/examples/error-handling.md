# Error Handling

Handle API errors gracefully using the ApiException type.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
var apiKey = GetApiKey();
using var client = new HuggingFaceClient("invalid-api-key");

try
{
    await client.Auth.GetWhoamiV2Async();
}
catch (ApiException ex)
{
    Console.WriteLine($"Status: {ex.StatusCode}");
    Console.WriteLine($"Message: {ex.Message}");
    Console.WriteLine($"Body: {ex.ResponseBody}");

}
```