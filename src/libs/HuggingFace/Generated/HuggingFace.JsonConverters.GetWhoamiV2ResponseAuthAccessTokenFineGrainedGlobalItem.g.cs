#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem>
    {
        /// <inheritdoc />
        public override global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem Read(
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
                        return global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItemExtensions.ToValueString(value));
        }
    }
}
