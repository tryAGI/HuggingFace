using Microsoft.Extensions.AI;

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_GenerateAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        var result = await generator.GenerateAsync(
            ["Hello world"],
            new EmbeddingGenerationOptions
            {
                ModelId = "sentence-transformers/all-MiniLM-L6-v2",
            });

        result.Should().NotBeNull();
        result.Should().HaveCount(1);
        result[0].Vector.Length.Should().BeGreaterThan(0);
        Console.WriteLine($"Embedding dimension: {result[0].Vector.Length}");
    }

    [TestMethod]
    public async Task EmbeddingGenerator_GenerateBatchAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        var result = await generator.GenerateAsync(
            ["Hello world", "How are you?"],
            new EmbeddingGenerationOptions
            {
                ModelId = "sentence-transformers/all-MiniLM-L6-v2",
            });

        result.Should().NotBeNull();
        result.Should().HaveCount(2);
        result[0].Vector.Length.Should().BeGreaterThan(0);
        result[1].Vector.Length.Should().Be(result[0].Vector.Length);
        Console.WriteLine($"Embedding dimension: {result[0].Vector.Length}");
    }
}
