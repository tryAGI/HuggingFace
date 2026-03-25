#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType? Read(
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
                        return global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
