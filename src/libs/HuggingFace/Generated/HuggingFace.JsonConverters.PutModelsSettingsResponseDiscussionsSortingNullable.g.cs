#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class PutModelsSettingsResponseDiscussionsSortingNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting? Read(
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
                        return global::HuggingFace.PutModelsSettingsResponseDiscussionsSortingExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.PutModelsSettingsResponseDiscussionsSortingExtensions.ToValueString(value.Value));
            }
        }
    }
}
