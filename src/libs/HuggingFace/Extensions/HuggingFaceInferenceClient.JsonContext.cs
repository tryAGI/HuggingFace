using System.Text.Json.Serialization;

namespace HuggingFace;

public sealed partial class HuggingFaceInferenceClient
{
    partial void Initialized(HttpClient client)
    {
        JsonSerializerContext = InferenceJsonContext.Default;
    }
}

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(ChatRequest))]
[JsonSerializable(typeof(ChatCompletion))]
[JsonSerializable(typeof(ChatCompletionChunk))]
[JsonSerializable(typeof(ErrorResponse))]
internal sealed partial class InferenceJsonContext : JsonSerializerContext;
