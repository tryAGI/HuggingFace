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
}
