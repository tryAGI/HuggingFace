# Rerank Texts

Rerank a list of texts by relevance to a query using the TEI reranking endpoint.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
var apiKey = GetApiKey();

using var client = new HuggingFaceEmbeddingClient(apiKey);

var results = await client.RerankAsync(
    query: "What is Deep Learning?",
    texts:
    [
        "Deep Learning is a subset of Machine Learning.",
        "The weather is sunny today.",
        "Neural networks are inspired by the human brain.",
    ],
    returnText: true);

foreach (var rank in results.OrderByDescending(r => r.Score))
{
    Console.WriteLine($"[{rank.Index}] score={rank.Score:F4} text={rank.Text}");
}
```