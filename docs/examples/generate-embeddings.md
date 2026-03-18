# Generate Embeddings

Generate text embeddings using the Microsoft.Extensions.AI IEmbeddingGenerator interface with HuggingFace TEI.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
using var client = new HuggingFaceEmbeddingClient(apiKey);
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var result = await generator.GenerateAsync(
    ["Hello world", "How are you?"],
    new EmbeddingGenerationOptions
    {
        ModelId = "sentence-transformers/all-MiniLM-L6-v2",
    });

Console.WriteLine($"Embedding dimension: {result[0].Vector.Length}");
Console.WriteLine($"Embeddings generated: {result.Count}");
```