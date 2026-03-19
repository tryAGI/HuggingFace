#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public class SagemakerResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.SagemakerResponse>
    {
        /// <inheritdoc />
        public override global::HuggingFace.SagemakerResponse Read(
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
            if (__jsonProps.Contains("usage")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::HuggingFace.GenerateResponse? generate = default;
            global::HuggingFace.ChatCompletion? chatCompletion = default;
            global::HuggingFace.CompletionFinal? completionFinal = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GenerateResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GenerateResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GenerateResponse).Name}");
                        generate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatCompletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatCompletion> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatCompletion).Name}");
                        chatCompletion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompletionFinal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompletionFinal> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompletionFinal).Name}");
                        completionFinal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (generate == null && chatCompletion == null && completionFinal == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GenerateResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GenerateResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GenerateResponse).Name}");
                    generate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatCompletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatCompletion> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatCompletion).Name}");
                    chatCompletion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompletionFinal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompletionFinal> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompletionFinal).Name}");
                    completionFinal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::HuggingFace.SagemakerResponse(
                generate,

                chatCompletion,

                completionFinal
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.SagemakerResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGenerate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GenerateResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GenerateResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GenerateResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Generate, typeInfo);
            }
            else if (value.IsChatCompletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatCompletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatCompletion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatCompletion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatCompletion, typeInfo);
            }
            else if (value.IsCompletionFinal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompletionFinal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompletionFinal?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompletionFinal).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionFinal, typeInfo);
            }
        }
    }
}