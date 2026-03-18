namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Rerank_BasicAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();

        var results = await client.RerankAsync(
            query: "What is Deep Learning?",
            texts:
            [
                "Deep Learning is a subset of Machine Learning.",
                "The weather is sunny today.",
                "Neural networks are inspired by the human brain.",
            ],
            returnText: true);

        results.Should().NotBeNull();
        results.Should().HaveCount(3);

        foreach (var rank in results.OrderBy(r => r.Index))
        {
            Console.WriteLine($"[{rank.Index}] score={rank.Score:F4} text={rank.Text}");
        }

        // The most relevant result should have the highest score
        var best = results.OrderByDescending(r => r.Score).First();
        (best.Text!.Contains("Deep Learning") || best.Text.Contains("Neural")).Should().BeTrue();
    }

    [TestMethod]
    public async Task Rerank_WithRawScoresAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();

        var results = await client.RerankAsync(
            query: "What is Deep Learning?",
            texts:
            [
                "Deep Learning is a subset of Machine Learning.",
                "The weather is sunny today.",
            ],
            rawScores: true);

        results.Should().NotBeNull();
        results.Should().HaveCount(2);

        foreach (var rank in results.OrderByDescending(r => r.Score))
        {
            Console.WriteLine($"[{rank.Index}] score={rank.Score:F4}");
        }
    }
}
