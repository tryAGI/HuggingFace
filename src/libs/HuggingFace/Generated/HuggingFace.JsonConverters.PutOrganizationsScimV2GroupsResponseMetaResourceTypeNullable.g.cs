#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class PutOrganizationsScimV2GroupsResponseMetaResourceTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.PutOrganizationsScimV2GroupsResponseMetaResourceType?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.PutOrganizationsScimV2GroupsResponseMetaResourceType? Read(
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
                        return global::HuggingFace.PutOrganizationsScimV2GroupsResponseMetaResourceTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.PutOrganizationsScimV2GroupsResponseMetaResourceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.PutOrganizationsScimV2GroupsResponseMetaResourceType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.PutOrganizationsScimV2GroupsResponseMetaResourceType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.PutOrganizationsScimV2GroupsResponseMetaResourceTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
