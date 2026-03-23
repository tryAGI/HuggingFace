#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Read(
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
                        return global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyExtensions.ToValueString(value.Value));
            }
        }
    }
}
