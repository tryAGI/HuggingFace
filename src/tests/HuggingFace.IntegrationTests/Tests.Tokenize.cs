namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Tokenize_SingleAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();

        var tokens = await client.TokenizeAsync(
            inputs: new TokenizeInput("Hello world"),
            addSpecialTokens: true);

        tokens.Should().NotBeNull();
        tokens.Should().HaveCount(1);
        tokens[0].Count.Should().BeGreaterThan(0);

        foreach (var token in tokens[0])
        {
            Console.WriteLine($"id={token.Id} text=\"{token.Text}\" special={token.Special}");
        }
    }

    [TestMethod]
    public async Task Tokenize_BatchAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();

        var tokens = await client.TokenizeAsync(
            inputs: new TokenizeInput(
                value1: null,
                value2: ["Hello world", "How are you?"]),
            addSpecialTokens: true);

        tokens.Should().NotBeNull();
        tokens.Should().HaveCount(2);
        tokens[0].Count.Should().BeGreaterThan(0);
        tokens[1].Count.Should().BeGreaterThan(0);
        Console.WriteLine($"Tokens in first input: {tokens[0].Count}");
        Console.WriteLine($"Tokens in second input: {tokens[1].Count}");
    }

    [TestMethod]
    public async Task Decode_SingleAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();

        // First tokenize to get token IDs
        var tokens = await client.TokenizeAsync(
            inputs: new TokenizeInput("Hello world"),
            addSpecialTokens: false);

        var tokenIds = tokens[0].Select(t => t.Id).ToList();
        Console.WriteLine($"Token IDs: [{string.Join(", ", tokenIds)}]");

        // Then decode back to text
        var decoded = await client.DecodeAsync(
            ids: new InputIds(value1: tokenIds, value2: null),
            skipSpecialTokens: true);

        decoded.Should().NotBeNull();
        decoded.Should().HaveCount(1);
        decoded[0].Should().NotBeNullOrWhiteSpace();
        Console.WriteLine($"Decoded: {decoded[0]}");
    }
}
