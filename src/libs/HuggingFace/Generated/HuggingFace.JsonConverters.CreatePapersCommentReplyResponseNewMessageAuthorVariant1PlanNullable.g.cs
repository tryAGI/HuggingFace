#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreatePapersCommentReplyResponseNewMessageAuthorVariant1PlanNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan? Read(
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
                        return global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1PlanExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1PlanExtensions.ToValueString(value.Value));
            }
        }
    }
}
