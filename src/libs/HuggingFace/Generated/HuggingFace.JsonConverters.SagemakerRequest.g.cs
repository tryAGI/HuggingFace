#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public class SagemakerRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.SagemakerRequest>
    {
        /// <inheritdoc />
        public override global::HuggingFace.SagemakerRequest Read(
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
            if (__jsonProps.Contains("inputs")) __score0++;
            if (__jsonProps.Contains("parameters")) __score0++;
            if (__jsonProps.Contains("stream")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("frequency_penalty")) __score1++;
            if (__jsonProps.Contains("logit_bias")) __score1++;
            if (__jsonProps.Contains("logprobs")) __score1++;
            if (__jsonProps.Contains("max_tokens")) __score1++;
            if (__jsonProps.Contains("messages")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("n")) __score1++;
            if (__jsonProps.Contains("presence_penalty")) __score1++;
            if (__jsonProps.Contains("response_format")) __score1++;
            if (__jsonProps.Contains("seed")) __score1++;
            if (__jsonProps.Contains("stop")) __score1++;
            if (__jsonProps.Contains("stream")) __score1++;
            if (__jsonProps.Contains("stream_options")) __score1++;
            if (__jsonProps.Contains("temperature")) __score1++;
            if (__jsonProps.Contains("tool_choice")) __score1++;
            if (__jsonProps.Contains("tool_prompt")) __score1++;
            if (__jsonProps.Contains("tools")) __score1++;
            if (__jsonProps.Contains("top_logprobs")) __score1++;
            if (__jsonProps.Contains("top_p")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("frequency_penalty")) __score2++;
            if (__jsonProps.Contains("max_tokens")) __score2++;
            if (__jsonProps.Contains("model")) __score2++;
            if (__jsonProps.Contains("prompt")) __score2++;
            if (__jsonProps.Contains("repetition_penalty")) __score2++;
            if (__jsonProps.Contains("seed")) __score2++;
            if (__jsonProps.Contains("stop")) __score2++;
            if (__jsonProps.Contains("stream")) __score2++;
            if (__jsonProps.Contains("suffix")) __score2++;
            if (__jsonProps.Contains("temperature")) __score2++;
            if (__jsonProps.Contains("top_p")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::HuggingFace.CompatGenerateRequest? compatGenerate = default;
            global::HuggingFace.ChatRequest? chat = default;
            global::HuggingFace.CompletionRequest? completion = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompatGenerateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompatGenerateRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompatGenerateRequest).Name}");
                        compatGenerate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatRequest).Name}");
                        chat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompletionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompletionRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompletionRequest).Name}");
                        completion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (compatGenerate == null && chat == null && completion == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompatGenerateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompatGenerateRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompatGenerateRequest).Name}");
                    compatGenerate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatRequest).Name}");
                    chat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompletionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompletionRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompletionRequest).Name}");
                    completion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::HuggingFace.SagemakerRequest(
                compatGenerate,

                chat,

                completion
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.SagemakerRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompatGenerate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompatGenerateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompatGenerateRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompatGenerateRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompatGenerate, typeInfo);
            }
            else if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeInfo);
            }
            else if (value.IsCompletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompletionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompletionRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompletionRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion, typeInfo);
            }
        }
    }
}