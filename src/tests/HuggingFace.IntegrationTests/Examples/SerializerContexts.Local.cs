namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Hub_LocalSerializerContext()
    {
        using var handler = new LocalJsonHandler("{\"text-classification\":[]}");
        using var httpClient = new HttpClient(handler);
        using var client = new HuggingFaceClient("local-key", httpClient: httpClient, disposeHttpClient: false);

        var tags = await client.Models.GetModelsTagsByTypeAsync();

        tags.Should().ContainKey("text-classification");
    }

    [TestMethod]
    public async Task HubLeaf_LocalSerializerContext()
    {
        using var handler = new LocalJsonHandler("{\"text-classification\":[]}");
        using var httpClient = new HttpClient(handler);
        using var client = new ModelsClient("local-key", httpClient: httpClient, disposeHttpClient: false);

        var tags = await client.GetModelsTagsByTypeAsync();

        client.JsonSerializerContext.GetType().Name.Should().Be("ModelsSourceGenerationContext");
        tags.Should().ContainKey("text-classification");
    }

    [TestMethod]
    public async Task Embeddings_LocalSerializerContext()
    {
        using var handler = new LocalJsonHandler("[[0.25,0.5]]");
        using var httpClient = new HttpClient(handler);
        using var client = new HuggingFaceEmbeddingClient("local-key", httpClient: httpClient, disposeHttpClient: false);

        var embeddings = await client.EmbedAsync(inputs: new Input("Hello world"), normalize: true);

        handler.RequestBody.Should().Contain("Hello world");
        embeddings[0].Should().HaveCount(2);
    }

    private sealed class LocalJsonHandler(string responseBody) : HttpMessageHandler
    {
        public string? RequestBody { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            RequestBody = request.Content is null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent(responseBody, System.Text.Encoding.UTF8, "application/json"),
            };
        }
    }
}
