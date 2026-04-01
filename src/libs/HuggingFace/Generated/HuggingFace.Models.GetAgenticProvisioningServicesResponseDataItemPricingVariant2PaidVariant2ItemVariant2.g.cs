
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant2ItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"stripe_price"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "stripe_price";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StripePrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freeform")]
        public string? Freeform { get; set; }

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
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant2ItemVariant2" /> class.
        /// </summary>
        /// <param name="stripePrice"></param>
        /// <param name="freeform"></param>
        /// <param name="configuration"></param>
        /// <param name="isDefault"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant2ItemVariant2(
            string stripePrice,
            string? freeform,
            object? configuration,
            bool? isDefault,
            string type = "stripe_price")
        {
            this.Type = type;
            this.StripePrice = stripePrice ?? throw new global::System.ArgumentNullException(nameof(stripePrice));
            this.Freeform = freeform;
            this.Configuration = configuration;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant2ItemVariant2" /> class.
        /// </summary>
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant2PaidVariant2ItemVariant2()
        {
        }
    }
}