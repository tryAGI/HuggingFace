/*
order: 40
title: Rerank Texts
slug: rerank-texts

Rerank a list of texts by relevance to a query using the TEI reranking endpoint.
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_RerankTexts()
    {
        var apiKey = Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY") ??
            throw new AssertInconclusiveException("HUGGINGFACE_API_KEY environment variable is not found.");

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

        results.Should().HaveCount(3);
    }
}
