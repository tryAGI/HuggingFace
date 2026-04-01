
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningServicesResponseDataItemPricingVariant3Component
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2>> Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant3Component" /> class.
        /// </summary>
        /// <param name="options"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant3Component(
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2>> options)
        {
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant3Component" /> class.
        /// </summary>
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant3Component()
        {
        }
    }
}