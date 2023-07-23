# HuggingFace

[![Nuget package](https://img.shields.io/nuget/vpre/HuggingFace)](https://www.nuget.org/packages/HuggingFace/)
[![dotnet](https://github.com/tryAGI/HuggingFace/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/HuggingFace/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/HuggingFace)](https://github.com/tryAGI/HuggingFace/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

Generated C# SDK based on HuggingFace OpenAPI specification using NSwag.  
Includes [tokenizer](https://github.com/tryAGI/Tiktoken) and some helper methods.

### Usage
```csharp
using HuggingFace;

using var client = new HttpClient();
var api = new HuggingFaceApi(apiKey, client);
var response = await api.GenerateTextAsync(
    RecommendedModelIds.Gpt2,
    new GenerateTextRequest
    {
        Inputs = "Hello",
        Parameters = new GenerateTextRequestParameters
        {
            Max_new_tokens = 250,
            Return_full_text = false,
        },
        Options = new GenerateTextRequestOptions
        {
            Use_cache = true,
            Wait_for_model = false,
        },
    });
```

## Support

Priority place for bugs: https://github.com/tryAGI/HuggingFace/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/HuggingFace/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  