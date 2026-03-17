#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitieNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie? Read(
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
                        return global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitieExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitieExtensions.ToValueString(value.Value));
            }
        }
    }
}
