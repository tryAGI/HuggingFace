#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource? Read(
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
                        return global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
