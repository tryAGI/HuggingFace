namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Phi3()
    {
        using var client = GetAuthenticatedClient();
        
        var response = await client.GenerateTextAsync(
            "microsoft/Phi-3-mini-4k-instruct",
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
