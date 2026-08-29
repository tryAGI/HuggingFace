#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType? Read(
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
                        return global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
