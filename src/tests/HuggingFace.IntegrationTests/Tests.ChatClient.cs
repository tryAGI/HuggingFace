using Microsoft.Extensions.AI;

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    //// ## Chat Client (IChatClient)
    ////
    //// The `HuggingFaceInferenceClient` implements the `IChatClient` interface
    //// from Microsoft.Extensions.AI, enabling a standardized chat experience
    //// with HuggingFace-hosted models via the TGI (Text Generation Inference) API.

    //// ### Non-streaming chat completion
    ////
    //// Use `GetResponseAsync` for a single request/response exchange:
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

    //// ### Streaming chat completion
    ////
    //// Use `GetStreamingResponseAsync` to receive tokens as they are generated:
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
