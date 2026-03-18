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

    private static HuggingFaceInferenceClient GetAuthenticatedInferenceClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY") ??
            throw new AssertInconclusiveException("HUGGINGFACE_API_KEY environment variable is not found.");

        return new HuggingFaceInferenceClient(apiKey);
    }

    private static HuggingFaceEmbeddingClient GetAuthenticatedEmbeddingClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY") ??
            throw new AssertInconclusiveException("HUGGINGFACE_API_KEY environment variable is not found.");

        return new HuggingFaceEmbeddingClient(apiKey);
    }
}
