#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateCollectionsResponseItemVariant1DatasetsServerInfoViewerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer>
    {
        /// <inheritdoc />
        public override global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer Read(
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
                        return global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoViewerExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoViewerExtensions.ToValueString(value));
        }
    }
}
