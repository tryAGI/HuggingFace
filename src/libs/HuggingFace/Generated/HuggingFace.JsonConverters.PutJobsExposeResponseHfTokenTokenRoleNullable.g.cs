#nullable enable

namespace HuggingFace.JsonConverters
{
    /// <inheritdoc />
    public sealed class PutJobsExposeResponseHfTokenTokenRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HuggingFace.PutJobsExposeResponseHfTokenTokenRole?>
    {
        /// <inheritdoc />
        public override global::HuggingFace.PutJobsExposeResponseHfTokenTokenRole? Read(
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
                        return global::HuggingFace.PutJobsExposeResponseHfTokenTokenRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::HuggingFace.PutJobsExposeResponseHfTokenTokenRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::HuggingFace.PutJobsExposeResponseHfTokenTokenRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HuggingFace.PutJobsExposeResponseHfTokenTokenRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::HuggingFace.PutJobsExposeResponseHfTokenTokenRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
