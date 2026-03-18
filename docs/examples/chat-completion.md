# Chat Completion

Send a chat message to a HuggingFace-hosted model using the Microsoft.Extensions.AI IChatClient interface.

This example assumes `using HuggingFace;` is in scope and `apiKey` contains your HuggingFace API key.

```csharp
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
```