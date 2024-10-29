namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Gpt2()
    {
        using var client = GetAuthenticatedClient();
        
        var response = await client.GenerateTextAsync(
            "gpt2",
            new GenerateTextRequest
            {
                Inputs = "Give random 5 words in response",
                Parameters = new GenerateTextRequestParameters
                {
                    MaxNewTokens = 250,
                },
                Options = new GenerateTextRequestOptions(),
            });
        response.Should().NotBeEmpty();

        foreach (var value in response)
        {
            Console.WriteLine(value.GeneratedText);
        }
    }
}
