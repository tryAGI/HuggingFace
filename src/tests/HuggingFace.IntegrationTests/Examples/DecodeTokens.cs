/*
order: 90
title: Decode Tokens
slug: decode-tokens

Tokenize text and decode it back using the TEI tokenization and decode endpoints.
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_DecodeTokens()
    {
        var apiKey = GetApiKey();

        using var client = new HuggingFaceEmbeddingClient(apiKey);

        //// Tokenize text into token IDs.
        var tokens = await client.TokenizeAsync(
            inputs: new TokenizeInput("Hello world"),
            addSpecialTokens: false);

        var tokenIds = tokens[0].Select(t => t.Id).ToList();
        Console.WriteLine($"Token IDs: [{string.Join(", ", tokenIds)}]");

        //// Decode token IDs back to text.
        var decoded = await client.DecodeAsync(
            ids: new InputIds(inputIdsVariant1: tokenIds, inputIdsVariant2: null),
            skipSpecialTokens: true);

        Console.WriteLine($"Decoded: {decoded[0]}");

        decoded[0].Should().NotBeNullOrWhiteSpace();
    }
}
