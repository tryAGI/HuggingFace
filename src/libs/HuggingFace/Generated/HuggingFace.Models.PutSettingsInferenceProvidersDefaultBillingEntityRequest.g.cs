
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutSettingsInferenceProvidersDefaultBillingEntityRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSettingsInferenceProvidersDefaultBillingEntityRequest" /> class.
        /// </summary>
        /// <param name="orgId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutSettingsInferenceProvidersDefaultBillingEntityRequest(
            string? orgId)
        {
            this.OrgId = orgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSettingsInferenceProvidersDefaultBillingEntityRequest" /> class.
        /// </summary>
        public PutSettingsInferenceProvidersDefaultBillingEntityRequest()
        {
        }

    }
}