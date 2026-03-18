/*
order: 50
title: Similarity Scoring
slug: similarity-scoring

Compute cosine similarity between a source sentence and a list of candidate sentences.
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SimilarityScoring()
    {
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

        scores.Should().HaveCount(3);
    }
}
