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

            var
            readerCopy = reader;
            global::HuggingFace.GenerateResponse? generate = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GenerateResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GenerateResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GenerateResponse).Name}");
                generate = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::HuggingFace.ChatCompletion? chatCompletion = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatCompletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatCompletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatCompletion).Name}");
                chatCompletion = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::HuggingFace.CompletionFinal? completionFinal = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompletionFinal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompletionFinal> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompletionFinal).Name}");
                completionFinal = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::HuggingFace.SagemakerResponse(
                generate,

                chatCompletion,

                completionFinal
                );

            if (generate != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GenerateResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GenerateResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GenerateResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (chatCompletion != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatCompletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatCompletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatCompletion).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (completionFinal != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompletionFinal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompletionFinal> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompletionFinal).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

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