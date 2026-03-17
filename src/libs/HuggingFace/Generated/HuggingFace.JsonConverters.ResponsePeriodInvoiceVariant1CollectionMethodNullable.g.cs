#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponsePeriodInvoiceVariant1CollectionMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.ResponsePeriodInvoiceVariant1CollectionMethod?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.ResponsePeriodInvoiceVariant1CollectionMethod? Read(
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
                        return global::HuggingFace.ResponsePeriodInvoiceVariant1CollectionMethodExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.ResponsePeriodInvoiceVariant1CollectionMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.ResponsePeriodInvoiceVariant1CollectionMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.ResponsePeriodInvoiceVariant1CollectionMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.ResponsePeriodInvoiceVariant1CollectionMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
