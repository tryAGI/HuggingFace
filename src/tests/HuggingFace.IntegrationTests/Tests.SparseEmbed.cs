namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbedSparse_NativeAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();

        var sparseEmbeddings = await client.EmbedSparseAsync(
            inputs: new Input("Hello world"));

        sparseEmbeddings.Should().NotBeNull();
        sparseEmbeddings.Should().HaveCount(1);
        sparseEmbeddings[0].Count.Should().BeGreaterThan(0);

        foreach (var sv in sparseEmbeddings[0].Take(5))
        {
            Console.WriteLine($"index={sv.Index} value={sv.Value:F4}");
        }
    }

    [TestMethod]
    public async Task EmbedSparse_NativeBatchAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();

        var inputTypes = new List<InputType>
        {
            new("Hello world"),
            new("How are you?"),
        };

        var sparseEmbeddings = await client.EmbedSparseAsync(
            inputs: new Input(value1: null, value2: inputTypes));

        sparseEmbeddings.Should().NotBeNull();
        sparseEmbeddings.Should().HaveCount(2);
        sparseEmbeddings[0].Count.Should().BeGreaterThan(0);
        sparseEmbeddings[1].Count.Should().BeGreaterThan(0);
        Console.WriteLine($"Sparse dims: [{sparseEmbeddings[0].Count}, {sparseEmbeddings[1].Count}]");
    }
}
