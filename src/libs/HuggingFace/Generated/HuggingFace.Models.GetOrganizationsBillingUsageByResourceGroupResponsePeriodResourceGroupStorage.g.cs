
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupStorage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateGB")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PrivateGB { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicGB")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PublicGB { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupStorage" /> class.
        /// </summary>
        /// <param name="privateGB"></param>
        /// <param name="publicGB"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupStorage(
            double privateGB,
            double publicGB)
        {
            this.PrivateGB = privateGB;
            this.PublicGB = publicGB;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupStorage" /> class.
        /// </summary>
        public GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupStorage()
        {
        }

    }
}