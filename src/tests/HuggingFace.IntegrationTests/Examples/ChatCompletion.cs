/*
order: 10
title: Chat Completion
slug: chat-completion

Send a chat message to a HuggingFace-hosted model using the Microsoft.Extensions.AI IChatClient interface.
*/

using Microsoft.Extensions.AI;

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ChatCompletion()
    {
        var apiKey = Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY") ??
            throw new AssertInconclusiveException("HUGGINGFACE_API_KEY environment variable is not found.");

        using var client = new HuggingFaceInferenceClient(apiKey);
        IChatClient chatClient = client;

        var response = await chatClient.GetResponseAsync(
            [new ChatMessage(ChatRole.User, "Say hello in one word.")],
            new ChatOptions
            {
                ModelId = "Qwen/Qwen2.5-Coder-32B-Instruct",
                MaxOutputTokens = 32,
            });

        Console.WriteLine(response.Text);

        response.Text.Should().NotBeNullOrWhiteSpace();
    }
}
