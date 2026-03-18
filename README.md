# HuggingFace

[![Nuget package](https://img.shields.io/nuget/vpre/HuggingFace)](https://www.nuget.org/packages/HuggingFace/)
[![dotnet](https://github.com/tryAGI/HuggingFace/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/HuggingFace/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/HuggingFace)](https://github.com/tryAGI/HuggingFace/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features
- Fully generated C# SDK based on [HuggingFace Hub](https://huggingface.co/docs/api-inference/), [TGI](https://huggingface.github.io/text-generation-inference/) and [TEI](https://huggingface.github.io/text-embeddings-inference/) OpenAPI specs using [AutoSDK](https://github.com/tryAGI/AutoSDK)
- Three typed clients: `HuggingFaceClient` (Hub API), `HuggingFaceInferenceClient` (TGI chat/completions), `HuggingFaceEmbeddingClient` (TEI embeddings/reranking)
- Microsoft.Extensions.AI support: `IChatClient` and `IEmbeddingGenerator<string, Embedding<float>>`
- All modern .NET features — nullability, trimming, NativeAOT, source-generated JSON
- Targets net10.0

## Getting Started

### Installation
```bash
dotnet add package HuggingFace
```

### Authentication
All clients require a HuggingFace API key. Get one at [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens).

```csharp
using HuggingFace;

// Chat and completions (TGI)
using var inferenceClient = new HuggingFaceInferenceClient(apiKey);

// Embeddings, reranking, similarity (TEI)
using var embeddingClient = new HuggingFaceEmbeddingClient(apiKey);

// Hub API (model info, datasets, etc.)
using var hubClient = new HuggingFaceClient(apiKey);
```

## Examples

<!-- EXAMPLES:START -->
### Chat Completion
Send a chat message to a HuggingFace-hosted model using the Microsoft.Extensions.AI IChatClient interface.

```csharp
var apiKey = GetApiKey();
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

### Streaming Chat Completion
Stream chat completion tokens as they are generated using the IChatClient interface.

```csharp
var apiKey = GetApiKey();

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

### Generate Embeddings
Generate text embeddings using the Microsoft.Extensions.AI IEmbeddingGenerator interface with HuggingFace TEI.

```csharp
var apiKey = GetApiKey();

using var client = new HuggingFaceEmbeddingClient(apiKey);
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var result = await generator.GenerateAsync(
    ["Hello world", "How are you?"],
    new EmbeddingGenerationOptions
    {
        ModelId = "sentence-transformers/all-MiniLM-L6-v2",
    });

Console.WriteLine($"Embedding dimension: {result[0].Vector.Length}");
Console.WriteLine($"Embeddings generated: {result.Count}");
```

### Rerank Texts
Rerank a list of texts by relevance to a query using the TEI reranking endpoint.

```csharp
var apiKey = GetApiKey();

using var client = new HuggingFaceEmbeddingClient(apiKey);

var results = await client.RerankAsync(
    query: "What is Deep Learning?",
    texts:
    [
        "Deep Learning is a subset of Machine Learning.",
        "The weather is sunny today.",
        "Neural networks are inspired by the human brain.",
    ],
    returnText: true);

foreach (var rank in results.OrderByDescending(r => r.Score))
{
    Console.WriteLine($"[{rank.Index}] score={rank.Score:F4} text={rank.Text}");
}
```

### Similarity Scoring
Compute cosine similarity between a source sentence and a list of candidate sentences.

```csharp
var apiKey = GetApiKey();

using var client = new HuggingFaceEmbeddingClient(apiKey);

var scores = await client.SimilarityAsync(
    inputs: new SimilarityInput
    {
        SourceSentence = "What is Deep Learning?",
        Sentences =
        [
            "Deep Learning is a subset of Machine Learning.",
            "The weather is sunny today.",
            "Neural networks are inspired by the human brain.",
        ],
    });

for (var i = 0; i < scores.Count; i++)
{
    Console.WriteLine($"[{i}] similarity={scores[i]:F4}");
}
```

### Tokenize Text
Tokenize text into tokens using the TEI tokenization endpoint.

```csharp
var apiKey = GetApiKey();

using var client = new HuggingFaceEmbeddingClient(apiKey);

var tokens = await client.TokenizeAsync(
    inputs: new TokenizeInput("Hello world"),
    addSpecialTokens: true);

foreach (var token in tokens[0])
{
    Console.WriteLine($"id={token.Id} text=\"{token.Text}\" special={token.Special}");
}
```

### Sparse Embeddings
Generate sparse embeddings for text using the TEI sparse embedding endpoint.

```csharp
var apiKey = GetApiKey();

using var client = new HuggingFaceEmbeddingClient(apiKey);

var sparseEmbeddings = await client.EmbedSparseAsync(
    inputs: new Input("Hello world"));

foreach (var sv in sparseEmbeddings[0].Take(5))
{
    Console.WriteLine($"index={sv.Index} value={sv.Value:F4}");
}
```

### Native Embeddings
Generate dense embeddings using the TEI-native embed endpoint with normalization control.

```csharp
var apiKey = GetApiKey();

using var client = new HuggingFaceEmbeddingClient(apiKey);

var embeddings = await client.EmbedAsync(
    inputs: new Input("Hello world"),
    normalize: true);

Console.WriteLine($"Embedding dimension: {embeddings[0].Count}");
```

### Decode Tokens
Tokenize text and decode it back using the TEI tokenization and decode endpoints.

```csharp
var apiKey = GetApiKey();

using var client = new HuggingFaceEmbeddingClient(apiKey);

// Tokenize text into token IDs.
var tokens = await client.TokenizeAsync(
    inputs: new TokenizeInput("Hello world"),
    addSpecialTokens: false);

var tokenIds = tokens[0].Select(t => t.Id).ToList();
Console.WriteLine($"Token IDs: [{string.Join(", ", tokenIds)}]");

// Decode token IDs back to text.
var decoded = await client.DecodeAsync(
    ids: new InputIds(value1: tokenIds, value2: null),
    skipSpecialTokens: true);

Console.WriteLine($"Decoded: {decoded[0]}");
```

### Who Am I
Get the authenticated user's account information using the Hub API.

```csharp
var apiKey = GetApiKey();
using var client = new HuggingFaceClient(apiKey);

var response = await client.Auth.GetWhoamiV2Async();

Console.WriteLine($"User: {response}");
```

### Trending Models
List recently trending models, datasets, and spaces on the HuggingFace Hub.

```csharp
var apiKey = GetApiKey();
using var client = new HuggingFaceClient(apiKey);

var response = await client.Models.GetTrendingAsync(limit: 5);

foreach (var item in response.RecentlyTrending)
{
    var id = item.Value1?.RepoData?.Id ?? item.Value2?.RepoData?.Id ?? item.Value3?.RepoData?.Id;
    var author = item.Value1?.RepoData?.Author ?? item.Value2?.RepoData?.Author ?? item.Value3?.RepoData?.Author;
    if (id is not null)
    {
        Console.WriteLine($"{id} by {author}");
    }
}
```

### List Model Tags
List available model tags grouped by type from the HuggingFace Hub.

```csharp
var apiKey = GetApiKey();
using var client = new HuggingFaceClient(apiKey);

var tags = await client.Models.GetModelsTagsByTypeAsync();

foreach (var (tagType, tagList) in tags)
{
    Console.WriteLine($"{tagType}: {tagList.Count} tags");
}
```

### Search Models
Search for models, datasets, and spaces on the HuggingFace Hub using quicksearch.

```csharp
var apiKey = GetApiKey();
using var client = new HuggingFaceClient(apiKey);

var response = await client.RepoSearch.CreateQuicksearchAsync(
    request: new Request45
    {
        Q = "text-generation",
        Limit = 5,
        Exclude = [],
    });

Console.WriteLine($"Found {response.ModelsCount} models, {response.DatasetsCount} datasets");

foreach (var model in response.Models)
{
    Console.WriteLine($"  {model.Id} (weight={model.TrendingWeight:F2})");
}
```

### Error Handling
Handle API errors gracefully using the ApiException type.

```csharp
var apiKey = GetApiKey();
using var client = new HuggingFaceClient("invalid-api-key");

try
{
    await client.Auth.GetWhoamiV2Async();
}
catch (ApiException ex)
{
    Console.WriteLine($"Status: {ex.StatusCode}");
    Console.WriteLine($"Message: {ex.Message}");
    Console.WriteLine($"Body: {ex.ResponseBody}");

}
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/HuggingFace/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/HuggingFace/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## OpenAPI specs
- Serverless Inference OpenAPI spec - (Can't find the link)
- [Local Text Generation Inference OpenAPI spec](https://huggingface.github.io/text-generation-inference/openapi.json)
- [Local Text Embeddings Inference OpenAPI spec](https://huggingface.github.io/text-embeddings-inference/openapi.json)
- [Inference Endpoints (dedicated) OpenAPI spec](https://api.endpoints.huggingface.cloud/openapi.json)

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).
