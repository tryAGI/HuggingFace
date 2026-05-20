#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetPapersResponseLinkedModelAuthorDataVariant1PlanNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan? Read(
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
                        return global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1PlanExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1PlanExtensions.ToValueString(value.Value));
            }
        }
    }
}
