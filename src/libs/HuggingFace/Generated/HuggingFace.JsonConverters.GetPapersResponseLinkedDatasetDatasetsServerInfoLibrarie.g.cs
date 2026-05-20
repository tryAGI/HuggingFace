#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarieJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie Read(
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
                        return global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarieExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarieExtensions.ToValueString(value));
        }
    }
}
