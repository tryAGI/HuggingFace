#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public class MessageChunkJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.MessageChunk>
    {
        /// <inheritdoc />
        public override global::HuggingFace.MessageChunk Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.MessageChunkDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.MessageChunkDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::HuggingFace.MessageChunkDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::HuggingFace.MessageChunkVariant1? text = default;
            if (discriminator?.Type == global::HuggingFace.MessageChunkDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.MessageChunkVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.MessageChunkVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::HuggingFace.MessageChunkVariant1)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::HuggingFace.MessageChunkVariant2? imageUrl = default;
            if (discriminator?.Type == global::HuggingFace.MessageChunkDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.MessageChunkVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.MessageChunkVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::HuggingFace.MessageChunkVariant2)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::HuggingFace.MessageChunk(
                discriminator?.Type,
                text,

                imageUrl
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.MessageChunk value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.MessageChunkVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.MessageChunkVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.MessageChunkVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.MessageChunkVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.MessageChunkVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.MessageChunkVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl!, typeInfo);
            }
        }
    }
}