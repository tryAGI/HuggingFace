#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public class CompletionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.Completion>
    {
        /// <inheritdoc />
        public override global::HuggingFace.Completion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::HuggingFace.Completion(
                value1,

                value2
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.Completion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}