# Tokenize Text

Tokenize text into tokens using the TEI tokenization endpoint.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
using var client = new HuggingFaceEmbeddingClient(apiKey);

var tokens = await client.TokenizeAsync(
    inputs: new TokenizeInput("Hello world"),
    addSpecialTokens: true);

foreach (var token in tokens[0])
{
    Console.WriteLine($"id={token.Id} text=\"{token.Text}\" special={token.Special}");
}
```