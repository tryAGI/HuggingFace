#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public class OutputMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.OutputMessage>
    {
        /// <inheritdoc />
        public override global::HuggingFace.OutputMessage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::HuggingFace.TextMessage? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.TextMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.TextMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.TextMessage).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::HuggingFace.ToolCallMessage? toolCall = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolCallMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolCallMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolCallMessage).Name}");
                toolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::HuggingFace.OutputMessage(
                text,

                toolCall
                );

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.TextMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.TextMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.TextMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (toolCall != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolCallMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolCallMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolCallMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.OutputMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.TextMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.TextMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.TextMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HuggingFace.ToolCallMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HuggingFace.ToolCallMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HuggingFace.ToolCallMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCall, typeInfo);
            }
        }
    }
}