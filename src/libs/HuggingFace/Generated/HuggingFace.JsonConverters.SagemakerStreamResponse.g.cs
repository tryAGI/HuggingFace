#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public class SagemakerStreamResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.SagemakerStreamResponse>
    {
        /// <inheritdoc />
        public override global::HuggingFace.SagemakerStreamResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("details")) __score0++;
            if (__jsonProps.Contains("generated_text")) __score0++;
            if (__jsonProps.Contains("index")) __score0++;
            if (__jsonProps.Contains("token")) __score0++;
            if (__jsonProps.Contains("top_tokens")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("choices")) __score1++;
            if (__jsonProps.Contains("created")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("system_fingerprint")) __score1++;
            if (__jsonProps.Contains("usage")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("choices")) __score2++;
            if (__jsonProps.Contains("created")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("model")) __score2++;
            if (__jsonProps.Contains("system_fingerprint")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::HuggingFace.StreamResponse? streamResponse = default;
            global::HuggingFace.ChatCompletionChunk? chatCompletionChunk = default;
            global::HuggingFace.Chunk? chunk = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.StreamResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.StreamResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.StreamResponse).Name}");
                        streamResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatCompletionChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatCompletionChunk> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatCompletionChunk).Name}");
                        chatCompletionChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.Chunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.Chunk> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.Chunk).Name}");
                        chunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (streamResponse == null && chatCompletionChunk == null && chunk == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.StreamResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.StreamResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.StreamResponse).Name}");
                    streamResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatCompletionChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatCompletionChunk> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatCompletionChunk).Name}");
                    chatCompletionChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.Chunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.Chunk> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.Chunk).Name}");
                    chunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::HuggingFace.SagemakerStreamResponse(
                streamResponse,

                chatCompletionChunk,

                chunk
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.SagemakerStreamResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStreamResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.StreamResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.StreamResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.StreamResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamResponse!, typeInfo);
            }
            else if (value.IsChatCompletionChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatCompletionChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatCompletionChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatCompletionChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatCompletionChunk!, typeInfo);
            }
            else if (value.IsChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.Chunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.Chunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.Chunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chunk!, typeInfo);
            }
        }
    }
}