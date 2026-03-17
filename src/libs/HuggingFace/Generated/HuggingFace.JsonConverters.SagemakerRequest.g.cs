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

            var
            readerCopy = reader;
            global::HuggingFace.CompatGenerateRequest? compatGenerate = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompatGenerateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompatGenerateRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompatGenerateRequest).Name}");
                compatGenerate = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::HuggingFace.ChatRequest? chat = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatRequest).Name}");
                chat = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::HuggingFace.CompletionRequest? completion = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompletionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompletionRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompletionRequest).Name}");
                completion = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::HuggingFace.SagemakerRequest(
                compatGenerate,

                chat,

                completion
                );

            if (compatGenerate != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompatGenerateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompatGenerateRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompatGenerateRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (chat != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (completion != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.CompletionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.CompletionRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.CompletionRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

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