#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarieJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie Read(
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
                        return global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarieExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarieExtensions.ToValueString(value));
        }
    }
}
