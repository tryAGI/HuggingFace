#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public class GrammarTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GrammarType>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GrammarType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::HuggingFace.GrammarTypeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::HuggingFace.GrammarTypeVariant1? json = default;
            if (discriminator?.Type == global::HuggingFace.GrammarTypeDiscriminatorType.Json)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::HuggingFace.GrammarTypeVariant1)}");
                json = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::HuggingFace.GrammarTypeVariant2? regex = default;
            if (discriminator?.Type == global::HuggingFace.GrammarTypeDiscriminatorType.Regex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::HuggingFace.GrammarTypeVariant2)}");
                regex = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::HuggingFace.GrammarTypeVariant3? jsonSchema = default;
            if (discriminator?.Type == global::HuggingFace.GrammarTypeDiscriminatorType.JsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::HuggingFace.GrammarTypeVariant3)}");
                jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::HuggingFace.GrammarType(
                discriminator?.Type,
                json,

                regex,

                jsonSchema
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GrammarType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GrammarTypeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Json!, typeInfo);
            }
            else if (value.IsRegex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GrammarTypeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Regex!, typeInfo);
            }
            else if (value.IsJsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.GrammarTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.GrammarTypeVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.GrammarTypeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema!, typeInfo);
            }
        }
    }
}