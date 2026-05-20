#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetPapersResponseLinkedDatasetDatasetsServerInfoFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat? Read(
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
                        return global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
