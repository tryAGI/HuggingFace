# Streaming Chat Completion

Stream chat completion tokens as they are generated using the IChatClient interface.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
using var client = new HuggingFaceInferenceClient(apiKey);
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
```