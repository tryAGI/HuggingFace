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

            var
            readerCopy = reader;
            global::HuggingFace.StreamResponse? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.StreamResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.StreamResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.StreamResponse).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::HuggingFace.ChatCompletionChunk? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatCompletionChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatCompletionChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatCompletionChunk).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::HuggingFace.Chunk? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.Chunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.Chunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.Chunk).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::HuggingFace.SagemakerStreamResponse(
                value1,

                value2,

                value3
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.StreamResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.StreamResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.StreamResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatCompletionChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatCompletionChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatCompletionChunk).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.Chunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.Chunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.Chunk).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

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

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.StreamResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.StreamResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.StreamResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ChatCompletionChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ChatCompletionChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ChatCompletionChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.Chunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.Chunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.Chunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
        }
    }
}