
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2PaidVariant1
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_price")]
        public string? StripePrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public object? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2PaidVariant1" /> class.
        /// </summary>
        /// <param name="freeform"></param>
        /// <param name="stripePrice"></param>
        /// <param name="configuration"></param>
        /// <param name="isDefault"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2PaidVariant1(
            string freeform,
            string? stripePrice,
            object? configuration,
            bool? isDefault,
            string type = "freeform")
        {
            this.Type = type;
            this.Freeform = freeform ?? throw new global::System.ArgumentNullException(nameof(freeform));
            this.StripePrice = stripePrice;
            this.Configuration = configuration;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2PaidVariant1" /> class.
        /// </summary>
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant2PaidVariant1()
        {
        }
    }
}