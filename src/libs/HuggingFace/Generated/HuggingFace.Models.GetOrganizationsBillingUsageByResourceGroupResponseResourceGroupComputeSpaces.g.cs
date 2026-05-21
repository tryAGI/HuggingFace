
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsBillingUsageByResourceGroupResponseResourceGroupComputeSpaces
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uptimeSec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UptimeSec { get; set; }

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
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByResourceGroupResponseResourceGroupComputeSpaces" /> class.
        /// </summary>
        /// <param name="uptimeSec"></param>
        /// <param name="costCents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsBillingUsageByResourceGroupResponseResourceGroupComputeSpaces(
            double uptimeSec,
            double costCents)
        {
            this.UptimeSec = uptimeSec;
            this.CostCents = costCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByResourceGroupResponseResourceGroupComputeSpaces" /> class.
        /// </summary>
        public GetOrganizationsBillingUsageByResourceGroupResponseResourceGroupComputeSpaces()
        {
        }

    }
}