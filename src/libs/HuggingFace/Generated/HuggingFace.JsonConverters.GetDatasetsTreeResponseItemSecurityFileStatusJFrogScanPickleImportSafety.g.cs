#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafetyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety Read(
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
                        return global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafetyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafetyExtensions.ToValueString(value));
        }
    }
}
