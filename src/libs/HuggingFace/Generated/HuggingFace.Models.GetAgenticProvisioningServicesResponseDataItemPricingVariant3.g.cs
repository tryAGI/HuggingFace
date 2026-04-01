
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningServicesResponseDataItemPricingVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"component"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "component";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3Component Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant3" /> class.
        /// </summary>
        /// <param name="component"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant3(
            global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3Component component,
            string type = "component")
        {
            this.Type = type;
            this.Component = component ?? throw new global::System.ArgumentNullException(nameof(component));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant3" /> class.
        /// </summary>
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant3()
        {
        }
    }
}