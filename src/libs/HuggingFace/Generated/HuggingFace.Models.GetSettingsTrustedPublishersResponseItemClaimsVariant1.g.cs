
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSettingsTrustedPublishersResponseItemClaimsVariant1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"eq"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string Kind { get; set; } = "eq";

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
        /// Initializes a new instance of the <see cref="GetSettingsTrustedPublishersResponseItemClaimsVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSettingsTrustedPublishersResponseItemClaimsVariant1(
            string value,
            string kind = "eq")
        {
            this.Kind = kind;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSettingsTrustedPublishersResponseItemClaimsVariant1" /> class.
        /// </summary>
        public GetSettingsTrustedPublishersResponseItemClaimsVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="GetSettingsTrustedPublishersResponseItemClaimsVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static GetSettingsTrustedPublishersResponseItemClaimsVariant1 FromValue(string value)
        {
            return new GetSettingsTrustedPublishersResponseItemClaimsVariant1
            {
                Value = value,
            };
        }

    }
}