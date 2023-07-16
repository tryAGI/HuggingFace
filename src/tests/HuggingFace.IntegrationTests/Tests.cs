namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public class GeneralTests
{
    [TestMethod]
    public async Task ListModels()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        using var client = new HttpClient();
        var api = new OpenAiApi(apiKey, client);
        var models = await api.ListModelsAsync();
        models.Data.Should().NotBeEmpty();

        foreach (var model in models.Data)
        {
            Console.WriteLine($"{model.Id}");
        }
    }
}
