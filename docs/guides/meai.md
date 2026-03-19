# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The HuggingFace SDK implements `IChatClient` and `IEmbeddingGenerator<string, Embedding<float>>` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), providing unified interfaces for chat completions and text embeddings via HuggingFace Serverless Inference.

## Installation

```bash
dotnet add package tryAGI.HuggingFace
```

## Chat Completions

Chat completions use `HuggingFaceInferenceClient`, which implements `IChatClient`:

```csharp
using Microsoft.Extensions.AI;
using HuggingFace;

IChatClient client = new HuggingFaceInferenceClient(
    apiKey: Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY")!);

var response = await client.GetResponseAsync(
    "What is the capital of France?",
    new ChatOptions { ModelId = "Qwen/Qwen2.5-Coder-32B-Instruct" });

Console.WriteLine(response.Text);
```

## Streaming

```csharp
using Microsoft.Extensions.AI;
using HuggingFace;

IChatClient client = new HuggingFaceInferenceClient(
    apiKey: Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY")!);

await foreach (var update in client.GetStreamingResponseAsync(
    "Explain quantum computing in simple terms.",
    new ChatOptions { ModelId = "Qwen/Qwen2.5-Coder-32B-Instruct" }))
{
    Console.Write(update.Text);
}
```

## Tool Calling

```csharp
using Microsoft.Extensions.AI;
using HuggingFace;

IChatClient client = new HuggingFaceInferenceClient(
    apiKey: Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY")!);

var tool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is sunny, 22C.",
    "GetWeather",
    "Gets the current weather for a given location.");

var options = new ChatOptions
{
    ModelId = "Qwen/Qwen2.5-Coder-32B-Instruct",
    Tools = [tool],
};

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "What is the weather in London?"),
};

while (true)
{
    var response = await client.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Text Embeddings

Embeddings use `HuggingFaceEmbeddingClient`, which implements `IEmbeddingGenerator<string, Embedding<float>>`:

```csharp
using Microsoft.Extensions.AI;
using HuggingFace;

IEmbeddingGenerator<string, Embedding<float>> generator =
    new HuggingFaceEmbeddingClient(
        apiKey: Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY")!);

var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new EmbeddingGenerationOptions
    {
        ModelId = "sentence-transformers/all-MiniLM-L6-v2",
    });

Console.WriteLine($"Dimensions: {embeddings[0].Vector.Length}");
Console.WriteLine($"Input tokens: {embeddings.Usage?.InputTokenCount}");
```

## Custom Dimensions

```csharp
using Microsoft.Extensions.AI;
using HuggingFace;

IEmbeddingGenerator<string, Embedding<float>> generator =
    new HuggingFaceEmbeddingClient(
        apiKey: Environment.GetEnvironmentVariable("HUGGINGFACE_API_KEY")!);

var options = new EmbeddingGenerationOptions
{
    ModelId = "sentence-transformers/all-MiniLM-L6-v2",
    Dimensions = 128,
};

var embeddings = await generator.GenerateAsync(
    ["Compact embedding for efficient storage."], options);

Console.WriteLine($"Dimensions: {embeddings[0].Vector.Length}");
```

## Dependency Injection

```csharp
using Microsoft.Extensions.AI;
using HuggingFace;

var builder = WebApplication.CreateBuilder(args);
var apiKey = builder.Configuration["HuggingFace:ApiKey"]!;

builder.Services.AddSingleton<IChatClient>(
    new HuggingFaceInferenceClient(apiKey: apiKey));

builder.Services.AddSingleton<IEmbeddingGenerator<string, Embedding<float>>>(
    new HuggingFaceEmbeddingClient(apiKey: apiKey));
```

## Provider Metadata

```csharp
var chatMetadata = client.GetService<ChatClientMetadata>();
Console.WriteLine($"Provider: {chatMetadata?.ProviderName}"); // "HuggingFaceInferenceClient"

var embeddingMetadata = generator.GetService<EmbeddingGeneratorMetadata>();
Console.WriteLine($"Provider: {embeddingMetadata?.ProviderName}"); // "HuggingFaceEmbeddingClient"
```
