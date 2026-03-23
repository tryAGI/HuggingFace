#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetWhoamiV2ResponseOrgRoleInOrgNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg? Read(
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
                        return global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrgExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrgExtensions.ToValueString(value.Value));
            }
        }
    }
}
