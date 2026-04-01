
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2PaidVariant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2PaidVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2PaidVariant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2PaidVariant2> Paid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_service_ids")]
        public global::System.Collections.Generic.IList<string>? ParentServiceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2" /> class.
        /// </summary>
        /// <param name="paid"></param>
        /// <param name="default"></param>
        /// <param name="parentServiceIds"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2(
            global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2PaidVariant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2PaidVariant2> paid,
            bool? @default,
            global::System.Collections.Generic.IList<string>? parentServiceIds,
            string type = "paid")
        {
            this.Type = type;
            this.Paid = paid;
            this.Default = @default;
            this.ParentServiceIds = parentServiceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2" /> class.
        /// </summary>
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2()
        {
        }
    }
}