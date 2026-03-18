# Decode Tokens

Tokenize text and decode it back using the TEI tokenization and decode endpoints.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
var apiKey = GetApiKey();

using var client = new HuggingFaceEmbeddingClient(apiKey);

// Tokenize text into token IDs.
var tokens = await client.TokenizeAsync(
    inputs: new TokenizeInput("Hello world"),
    addSpecialTokens: false);

var tokenIds = tokens[0].Select(t => t.Id).ToList();
Console.WriteLine($"Token IDs: [{string.Join(", ", tokenIds)}]");

// Decode token IDs back to text.
var decoded = await client.DecodeAsync(
    ids: new InputIds(value1: tokenIds, value2: null),
    skipSpecialTokens: true);

Console.WriteLine($"Decoded: {decoded[0]}");
```