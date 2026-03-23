
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSettingsBillingUsageJobsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetSettingsBillingUsageJobsResponseUsage Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasAccess")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSettingsBillingUsageJobsResponse" /> class.
        /// </summary>
        /// <param name="usage"></param>
        /// <param name="hasAccess"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSettingsBillingUsageJobsResponse(
            global::HuggingFace.GetSettingsBillingUsageJobsResponseUsage usage,
            bool hasAccess)
        {
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.HasAccess = hasAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSettingsBillingUsageJobsResponse" /> class.
        /// </summary>
        public GetSettingsBillingUsageJobsResponse()
        {
        }
    }
}