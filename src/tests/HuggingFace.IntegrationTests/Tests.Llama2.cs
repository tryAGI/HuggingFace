namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Llama2()
    {
        using var api = GetAuthorizedApi();
        var response = await api.GenerateTextAsync(
            "meta-llama/Llama-2-7b-hf",
            new GenerateTextRequest
            {
                Inputs = "Give random 5 words in response",
                Parameters = new GenerateTextRequestParameters
                {
                    MaxNewTokens = 250,
                },
            });
        response.Should().NotBeEmpty();

        foreach (var value in response)
        {
            Console.WriteLine(value.GeneratedText);
        }
    }
}
