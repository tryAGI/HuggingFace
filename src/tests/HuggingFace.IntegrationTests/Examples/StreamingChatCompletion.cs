/*
order: 20
title: Streaming Chat Completion
slug: streaming-chat-completion

Stream chat completion tokens as they are generated using the IChatClient interface.
*/

using Microsoft.Extensions.AI;

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_StreamingChatCompletion()
    {
        using var client = GetAuthenticatedInferenceClient();
        IChatClient chatClient = client;

        await foreach (var update in chatClient.GetStreamingResponseAsync(
            [new ChatMessage(ChatRole.User, "Say hello in one word.")],
            new ChatOptions
            {
                ModelId = "Qwen/Qwen2.5-Coder-32B-Instruct",
                MaxOutputTokens = 32,
            }))
        {
            Console.Write(update.Text);
        }
    }
}
