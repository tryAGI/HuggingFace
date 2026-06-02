
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupStorage Storage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupInference Inference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupCompute Compute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup" /> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="inference"></param>
        /// <param name="compute"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup(
            global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupStorage storage,
            global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupInference inference,
            global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupCompute compute,
            string? id,
            string? name)
        {
            this.Id = id;
            this.Name = name;
            this.Storage = storage ?? throw new global::System.ArgumentNullException(nameof(storage));
            this.Inference = inference ?? throw new global::System.ArgumentNullException(nameof(inference));
            this.Compute = compute ?? throw new global::System.ArgumentNullException(nameof(compute));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup" /> class.
        /// </summary>
        public GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup()
        {
        }

    }
}