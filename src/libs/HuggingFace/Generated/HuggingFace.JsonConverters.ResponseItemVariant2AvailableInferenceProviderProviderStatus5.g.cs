#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseItemVariant2AvailableInferenceProviderProviderStatus5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderProviderStatus5>
    {
        /// <inheritdoc />
        public override global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderProviderStatus5 Read(
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
                        return global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderProviderStatus5Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderProviderStatus5)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderProviderStatus5);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderProviderStatus5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderProviderStatus5Extensions.ToValueString(value));
        }
    }
}
