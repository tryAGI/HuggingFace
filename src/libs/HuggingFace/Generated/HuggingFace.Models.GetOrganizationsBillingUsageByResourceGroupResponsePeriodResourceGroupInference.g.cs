
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupInference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costCents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CostCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupInference" /> class.
        /// </summary>
        /// <param name="requestCount"></param>
        /// <param name="costCents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupInference(
            double requestCount,
            double costCents)
        {
            this.RequestCount = requestCount;
            this.CostCents = costCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupInference" /> class.
        /// </summary>
        public GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupInference()
        {
        }

    }
}