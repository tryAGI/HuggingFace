#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus>
    {
        /// <inheritdoc />
        public override global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus Read(
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
                        return global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatusExtensions.ToValueString(value));
        }
    }
}
