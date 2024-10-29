# HuggingFace

[![Nuget package](https://img.shields.io/nuget/vpre/HuggingFace)](https://www.nuget.org/packages/HuggingFace/)
[![dotnet](https://github.com/tryAGI/HuggingFace/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/HuggingFace/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/HuggingFace)](https://github.com/tryAGI/HuggingFace/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- ~~Fully generated C# SDK based on [official HuggingFace OpenAPI specification](https://huggingface.github.io/text-generation-inference/openapi.json) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)~~
- ~~Same day update to support new features~~
- ~~Updated and supported automatically if there are no breaking changes~~
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Now supports only Serverless Inference API

### Usage
```csharp
using HuggingFace;

using var client = new HuggingFaceClient(apiKey, client);
var response = await api.GenerateTextAsync(
    "gpt2",
    new GenerateTextRequest
    {
        Inputs = "Hello",
        Parameters = new GenerateTextRequestParameters
        {
            MaxNewTokens = 250,
        },
    });
```

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