/*
order: 30
title: Generate Embeddings
slug: generate-embeddings

Generate text embeddings using the Microsoft.Extensions.AI IEmbeddingGenerator interface with HuggingFace TEI.
*/

using Microsoft.Extensions.AI;

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateEmbeddings()
    {
        using var client = GetAuthenticatedEmbeddingClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        var result = await generator.GenerateAsync(
            ["Hello world", "How are you?"],
            new EmbeddingGenerationOptions
            {
                ModelId = "sentence-transformers/all-MiniLM-L6-v2",
            });

        Console.WriteLine($"Embedding dimension: {result[0].Vector.Length}");
        Console.WriteLine($"Embeddings generated: {result.Count}");
    }
}
