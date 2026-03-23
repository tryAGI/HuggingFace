#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchCollectionsResponseDataGatingVariant3NotificationsModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.PatchCollectionsResponseDataGatingVariant3NotificationsMode>
    {
        /// <inheritdoc />
        public override global::HuggingFace.PatchCollectionsResponseDataGatingVariant3NotificationsMode Read(
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
                        return global::HuggingFace.PatchCollectionsResponseDataGatingVariant3NotificationsModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.PatchCollectionsResponseDataGatingVariant3NotificationsMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.PatchCollectionsResponseDataGatingVariant3NotificationsMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.PatchCollectionsResponseDataGatingVariant3NotificationsMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HuggingFace.PatchCollectionsResponseDataGatingVariant3NotificationsModeExtensions.ToValueString(value));
        }
    }
}
