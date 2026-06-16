
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupCompute
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeSpaces Spaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeEndpoints Endpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeJobs Jobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupCompute" /> class.
        /// </summary>
        /// <param name="spaces"></param>
        /// <param name="endpoints"></param>
        /// <param name="jobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupCompute(
            global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeSpaces spaces,
            global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeEndpoints endpoints,
            global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeJobs jobs)
        {
            this.Spaces = spaces ?? throw new global::System.ArgumentNullException(nameof(spaces));
            this.Endpoints = endpoints ?? throw new global::System.ArgumentNullException(nameof(endpoints));
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupCompute" /> class.
        /// </summary>
        public GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupCompute()
        {
        }

    }
}