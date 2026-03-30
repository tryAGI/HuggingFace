
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningServicesResponseDataItemPricingVariant2Paid
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"freeform"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "freeform";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freeform")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Freeform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant2Paid" /> class.
        /// </summary>
        /// <param name="freeform"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant2Paid(
            string freeform,
            string type = "freeform")
        {
            this.Type = type;
            this.Freeform = freeform ?? throw new global::System.ArgumentNullException(nameof(freeform));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant2Paid" /> class.
        /// </summary>
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant2Paid()
        {
        }
    }
}