# Similarity Scoring

Compute cosine similarity between a source sentence and a list of candidate sentences.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
var apiKey = Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY") ??
    throw new AssertInconclusiveException("HUGGINGFACE_API_KEY environment variable is not found.");

using var client = new HuggingFaceEmbeddingClient(apiKey);

var scores = await client.SimilarityAsync(
    inputs: new SimilarityInput
    {
        SourceSentence = "What is Deep Learning?",
        Sentences =
        [
            "Deep Learning is a subset of Machine Learning.",
            "The weather is sunny today.",
            "Neural networks are inspired by the human brain.",
        ],
    });

for (var i = 0; i < scores.Count; i++)
{
    Console.WriteLine($"[{i}] similarity={scores[i]:F4}");
}
```