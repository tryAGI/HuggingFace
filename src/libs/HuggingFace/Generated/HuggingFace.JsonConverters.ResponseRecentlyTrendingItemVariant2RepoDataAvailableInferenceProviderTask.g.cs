#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTaskJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask>
    {
        /// <inheritdoc />
        public override global::HuggingFace.ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask Read(
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
                        return global::HuggingFace.ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTaskExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HuggingFace.ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTaskExtensions.ToValueString(value));
        }
    }
}
