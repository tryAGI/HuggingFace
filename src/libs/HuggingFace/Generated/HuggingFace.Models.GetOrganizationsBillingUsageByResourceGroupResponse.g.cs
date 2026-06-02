
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsBillingUsageByResourceGroupResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periods")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriod> Periods { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByResourceGroupResponse" /> class.
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="periods"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsBillingUsageByResourceGroupResponse(
            string currency,
            global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriod> periods)
        {
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.Periods = periods ?? throw new global::System.ArgumentNullException(nameof(periods));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByResourceGroupResponse" /> class.
        /// </summary>
        public GetOrganizationsBillingUsageByResourceGroupResponse()
        {
        }

    }
}