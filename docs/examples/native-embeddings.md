# Native Embeddings

Generate dense embeddings using the TEI-native embed endpoint with normalization control.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
var apiKey = Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY") ??
    throw new AssertInconclusiveException("HUGGINGFACE_API_KEY environment variable is not found.");

using var client = new HuggingFaceEmbeddingClient(apiKey);

var embeddings = await client.EmbedAsync(
    inputs: new Input("Hello world"),
    normalize: true);

Console.WriteLine($"Embedding dimension: {embeddings[0].Count}");
```