namespace HuggingFace.IntegrationTests;

[TestClass]
public partial class Tests
{
    public static HuggingFaceApi GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY") ??
            throw new AssertInconclusiveException("HUGGINGFACE_API_KEY environment variable is not found.");

        return new HuggingFaceApi(apiKey);
    }
    
    [TestMethod]
    public async Task GenerateError()
    {
        using var api = GetAuthorizedApi();
        Func<Task> act = async () => await api.GenerateTextAsync(
            "gpt2",
            new GenerateTextRequest
            {
                Inputs = "Hello",
                Parameters = new GenerateTextRequestParameters
                {
                    MaxNewTokens = 2501,
                },
            });
        
        await act.Should().ThrowAsync<HttpRequestException>();
    }
}
