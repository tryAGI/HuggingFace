#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetJobsHardwareResponseItemAcceleratorManufacturerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer? Read(
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
                        return global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturerExtensions.ToValueString(value.Value));
            }
        }
    }
}
