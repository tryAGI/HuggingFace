/*
order: 25
title: Streaming Tool Calling
slug: streaming-tool-calling

Stream chat completion responses with tool calling using the IChatClient interface.
*/

using Microsoft.Extensions.AI;

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_StreamingToolCalling()
    {
        var apiKey = GetApiKey();

        using var client = new HuggingFaceInferenceClient(apiKey);
        IChatClient chatClient = client;

        //// Stream chat responses with tool calling using the MEAI IChatClient interface.
        //// Define a simple tool that returns the current weather.
        var tool = AIFunctionFactory.Create(
            (string location) => $"The weather in {location} is sunny, 72°F.",
            "get_weather",
            "Gets the current weather for a location.");

        var functionCalls = new List<FunctionCallContent>();
        ChatFinishReason? finishReason = null;

        await foreach (var update in chatClient.GetStreamingResponseAsync(
            [new ChatMessage(ChatRole.User, "What's the weather in San Francisco?")],
            new ChatOptions
            {
                ModelId = "Qwen/Qwen2.5-Coder-32B-Instruct",
                Tools = [tool],
            }))
        {
            functionCalls.AddRange(update.Contents.OfType<FunctionCallContent>());

            if (update.FinishReason is not null)
            {
                finishReason = update.FinishReason;
            }
        }

        //// The model should respond with tool calls.
        functionCalls.Should().NotBeEmpty();
        functionCalls[0].Name.Should().Be("get_weather");
        finishReason.Should().Be(ChatFinishReason.ToolCalls);
    }
}
