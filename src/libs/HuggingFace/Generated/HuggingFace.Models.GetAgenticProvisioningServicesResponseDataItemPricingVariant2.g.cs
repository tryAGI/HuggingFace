
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningServicesResponseDataItemPricingVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"paid"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "paid";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paid")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant1Variant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant1Variant2>?, global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant2ItemVariant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant2ItemVariant2>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant1Variant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant1Variant2>?, global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant2ItemVariant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant2ItemVariant2>>> Paid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant2" /> class.
        /// </summary>
        /// <param name="paid"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant2(
            global::HuggingFace.AnyOf<global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant1Variant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant1Variant2>?, global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant2ItemVariant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant2ItemVariant2>>> paid,
            string type = "paid")
        {
            this.Type = type;
            this.Paid = paid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant2" /> class.
        /// </summary>
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant2()
        {
        }
    }
}