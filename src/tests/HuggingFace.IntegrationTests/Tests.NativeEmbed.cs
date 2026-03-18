namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Embed_NativeAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();

        var embeddings = await client.EmbedAsync(
            inputs: new Input("Hello world"),
            normalize: true);

        embeddings.Should().NotBeNull();
        embeddings.Should().HaveCount(1);
        embeddings[0].Count.Should().BeGreaterThan(0);
        Console.WriteLine($"Embedding dimension: {embeddings[0].Count}");
    }

    [TestMethod]
    public async Task Embed_NativeBatchAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();

        var inputTypes = new List<InputType>
        {
            new("Hello world"),
            new("How are you?"),
        };

        var embeddings = await client.EmbedAsync(
            inputs: new Input(value1: null, value2: inputTypes),
            normalize: true);

        embeddings.Should().NotBeNull();
        embeddings.Should().HaveCount(2);
        embeddings[0].Count.Should().Be(embeddings[1].Count);
        Console.WriteLine($"Embedding dimension: {embeddings[0].Count}");
    }

    [TestMethod]
    public async Task EmbedAll_NativeAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();

        var allEmbeddings = await client.EmbedAllAsync(
            inputs: new Input("Hello world"));

        allEmbeddings.Should().NotBeNull();
        allEmbeddings.Should().HaveCount(1);
        // EmbedAll returns per-token embeddings (no pooling)
        allEmbeddings[0].Count.Should().BeGreaterThan(0);
        Console.WriteLine($"Tokens: {allEmbeddings[0].Count}, Dimensions: {allEmbeddings[0][0].Count}");
    }
}
