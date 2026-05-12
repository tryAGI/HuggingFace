#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetOrganizationsSettingsRepositoriesResponseItemTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType Read(
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
                        return global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemTypeExtensions.ToValueString(value));
        }
    }
}
