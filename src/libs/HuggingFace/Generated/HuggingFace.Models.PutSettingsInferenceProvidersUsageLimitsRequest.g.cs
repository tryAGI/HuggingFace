
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutSettingsInferenceProvidersUsageLimitsRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spendingLimitCents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SpendingLimitCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSettingsInferenceProvidersUsageLimitsRequest" /> class.
        /// </summary>
        /// <param name="spendingLimitCents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutSettingsInferenceProvidersUsageLimitsRequest(
            int spendingLimitCents)
        {
            this.SpendingLimitCents = spendingLimitCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSettingsInferenceProvidersUsageLimitsRequest" /> class.
        /// </summary>
        public PutSettingsInferenceProvidersUsageLimitsRequest()
        {
        }

    }
}