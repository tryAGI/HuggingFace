# Tokenize Text

Tokenize text into tokens using the TEI tokenization endpoint.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
var apiKey = Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY") ??
    throw new AssertInconclusiveException("HUGGINGFACE_API_KEY environment variable is not found.");

using var client = new HuggingFaceEmbeddingClient(apiKey);

var tokens = await client.TokenizeAsync(
    inputs: new TokenizeInput("Hello world"),
    addSpecialTokens: true);

foreach (var token in tokens[0])
{
    Console.WriteLine($"id={token.Id} text=\"{token.Text}\" special={token.Special}");
}
```