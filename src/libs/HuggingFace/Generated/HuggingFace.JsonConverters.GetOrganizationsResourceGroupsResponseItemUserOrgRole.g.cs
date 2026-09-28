#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetOrganizationsResourceGroupsResponseItemUserOrgRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUserOrgRole>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUserOrgRole Read(
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
                        return global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUserOrgRoleExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUserOrgRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUserOrgRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUserOrgRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUserOrgRoleExtensions.ToValueString(value));
        }
    }
}
