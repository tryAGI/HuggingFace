
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSettingsTrustedPublishersRequestClaimsVariant2
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"prefix"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string Kind { get; set; } = "prefix";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsTrustedPublishersRequestClaimsVariant2" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsTrustedPublishersRequestClaimsVariant2(
            string value,
            string kind = "prefix")
        {
            this.Kind = kind;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsTrustedPublishersRequestClaimsVariant2" /> class.
        /// </summary>
        public CreateSettingsTrustedPublishersRequestClaimsVariant2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateSettingsTrustedPublishersRequestClaimsVariant2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateSettingsTrustedPublishersRequestClaimsVariant2 FromValue(string value)
        {
            return new CreateSettingsTrustedPublishersRequestClaimsVariant2
            {
                Value = value,
            };
        }

    }
}