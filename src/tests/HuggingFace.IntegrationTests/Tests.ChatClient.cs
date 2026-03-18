using Microsoft.Extensions.AI;

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_GetResponseAsync()
    {
        using var client = GetAuthenticatedInferenceClient();
        IChatClient chatClient = client;

        var response = await chatClient.GetResponseAsync(
            [new ChatMessage(ChatRole.User, "Say hello in one word.")],
            new ChatOptions
            {
                ModelId = "Qwen/Qwen2.5-Coder-32B-Instruct",
                MaxOutputTokens = 32,
            });

        response.Should().NotBeNull();
        response.Messages.Should().NotBeEmpty();

        var text = response.Text;
        text.Should().NotBeNullOrWhiteSpace();
        Console.WriteLine($"Response: {text}");
    }

    [TestMethod]
    public async Task ChatClient_GetStreamingResponseAsync()
    {
        using var client = GetAuthenticatedInferenceClient();
        IChatClient chatClient = client;

        var chunks = new List<string>();
        await foreach (var update in chatClient.GetStreamingResponseAsync(
            [new ChatMessage(ChatRole.User, "Say hello in one word.")],
            new ChatOptions
            {
                ModelId = "Qwen/Qwen2.5-Coder-32B-Instruct",
                MaxOutputTokens = 32,
            }))
        {
            if (update.Text is { } text)
            {
                chunks.Add(text);
                Console.Write(text);
            }
        }

        Console.WriteLine();
        chunks.Should().NotBeEmpty();
    }
}
