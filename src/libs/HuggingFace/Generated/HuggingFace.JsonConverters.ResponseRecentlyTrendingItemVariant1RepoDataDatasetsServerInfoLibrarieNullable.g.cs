#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarieNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie? Read(
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
                        return global::HuggingFace.ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarieExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarieExtensions.ToValueString(value.Value));
            }
        }
    }
}
