namespace HuggingFace.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static HuggingFaceClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY") ??
            throw new AssertInconclusiveException("HUGGINGFACE_API_KEY environment variable is not found.");

        return new HuggingFaceClient(apiKey);
    }
    
    [TestMethod]
    public async Task GenerateError()
    {
        using var client = GetAuthenticatedClient();
        
        Func<Task> act = async () => await client.GenerateTextAsync(
            "gpt2",
            new GenerateTextRequest
            {
                Inputs = "Hello",
                Parameters = new GenerateTextRequestParameters
                {
                    MaxNewTokens = 2501,
                },
            });
        
        await act.Should().ThrowAsync<InvalidOperationException>();
    }
}
