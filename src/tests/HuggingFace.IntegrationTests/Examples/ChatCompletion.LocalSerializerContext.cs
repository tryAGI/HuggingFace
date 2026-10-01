using Microsoft.Extensions.AI;

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatCompletion_LocalSerializerContext()
    {
        using var handler = new ChatCompletionHandler();
        using var httpClient = new HttpClient(handler);
        using var client = new HuggingFaceInferenceClient("local-key", httpClient: httpClient, disposeHttpClient: false);
        IChatClient chatClient = client;

        var response = await chatClient.GetResponseAsync("Hello");

        handler.RequestBody.Should().Contain("Hello");
        response.ResponseId.Should().Be("local-test");
    }

    private sealed class ChatCompletionHandler : HttpMessageHandler
    {
        public string? RequestBody { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            RequestBody = await request.Content!.ReadAsStringAsync(cancellationToken);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("{\"choices\":[],\"created\":0,\"id\":\"local-test\",\"model\":\"local\",\"system_fingerprint\":\"\",\"usage\":{\"prompt_tokens\":0,\"completion_tokens\":0,\"total_tokens\":0}}"),
            };
        }
    }
}
