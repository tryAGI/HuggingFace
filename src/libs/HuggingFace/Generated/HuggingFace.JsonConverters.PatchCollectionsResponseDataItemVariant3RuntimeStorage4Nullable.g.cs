#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchCollectionsResponseDataItemVariant3RuntimeStorage4NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStorage4?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStorage4? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStorage4Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStorage4)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStorage4?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStorage4? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStorage4Extensions.ToValueString(value.Value));
            }
        }
    }
}
