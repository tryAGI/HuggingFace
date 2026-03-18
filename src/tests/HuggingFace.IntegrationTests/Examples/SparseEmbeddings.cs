/*
order: 70
title: Sparse Embeddings
slug: sparse-embeddings

Generate sparse embeddings for text using the TEI sparse embedding endpoint.
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SparseEmbeddings()
    {
        var apiKey = Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY") ??
            throw new AssertInconclusiveException("HUGGINGFACE_API_KEY environment variable is not found.");

        using var client = new HuggingFaceEmbeddingClient(apiKey);

        var sparseEmbeddings = await client.EmbedSparseAsync(
            inputs: new Input("Hello world"));

        foreach (var sv in sparseEmbeddings[0].Take(5))
        {
            Console.WriteLine($"index={sv.Index} value={sv.Value:F4}");
        }

        sparseEmbeddings[0].Count.Should().BeGreaterThan(0);
    }
}
