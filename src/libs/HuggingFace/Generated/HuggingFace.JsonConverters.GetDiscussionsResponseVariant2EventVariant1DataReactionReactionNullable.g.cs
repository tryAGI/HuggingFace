#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDiscussionsResponseVariant2EventVariant1DataReactionReactionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReactionReaction?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReactionReaction? Read(
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
                        return global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReactionReactionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReactionReaction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReactionReaction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReactionReaction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReactionReactionExtensions.ToValueString(value.Value));
            }
        }
    }
}
