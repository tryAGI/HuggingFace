/*
order: 60
title: Tokenize Text
slug: tokenize-text

Tokenize text into tokens using the TEI tokenization endpoint.
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Tokenize()
    {
        var apiKey = GetApiKey();

        using var client = new HuggingFaceEmbeddingClient(apiKey);

        var tokens = await client.TokenizeAsync(
            inputs: new TokenizeInput("Hello world"),
            addSpecialTokens: true);

        foreach (var token in tokens[0])
        {
            Console.WriteLine($"id={token.Id} text=\"{token.Text}\" special={token.Special}");
        }

        tokens[0].Count.Should().BeGreaterThan(0);
    }
}
