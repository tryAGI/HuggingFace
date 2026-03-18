# Sparse Embeddings

Generate sparse embeddings for text using the TEI sparse embedding endpoint.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
var apiKey = Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY") ??
    throw new AssertInconclusiveException("HUGGINGFACE_API_KEY environment variable is not found.");

using var client = new HuggingFaceEmbeddingClient(apiKey);

var sparseEmbeddings = await client.EmbedSparseAsync(
    inputs: new Input("Hello world"));

foreach (var sv in sparseEmbeddings[0].Take(5))
{
    Console.WriteLine($"index={sv.Index} value={sv.Value:F4}");
}
```