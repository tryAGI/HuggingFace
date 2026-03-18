/*
order: 80
title: Native Embeddings
slug: native-embeddings

Generate dense embeddings using the TEI-native embed endpoint with normalization control.
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_NativeEmbeddings()
    {
        var apiKey = Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY") ??
            throw new AssertInconclusiveException("HUGGINGFACE_API_KEY environment variable is not found.");

        using var client = new HuggingFaceEmbeddingClient(apiKey);

        var embeddings = await client.EmbedAsync(
            inputs: new Input("Hello world"),
            normalize: true);

        Console.WriteLine($"Embedding dimension: {embeddings[0].Count}");

        embeddings[0].Count.Should().BeGreaterThan(0);
    }
}
