#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum? Read(
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
                        return global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
