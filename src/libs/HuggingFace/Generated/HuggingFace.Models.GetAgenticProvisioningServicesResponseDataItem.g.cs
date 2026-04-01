
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningServicesResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemCategorie> Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetAgenticProvisioningServicesResponseDataItemKindJsonConverter))]
        public global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemKind? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3> Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kyc")]
        public global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemKyc? Kyc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_schema")]
        public global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemConfigurationSchema? ConfigurationSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_updates")]
        public global::System.Collections.Generic.IList<string>? AllowedUpdates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="categories"></param>
        /// <param name="pricing"></param>
        /// <param name="kind"></param>
        /// <param name="group"></param>
        /// <param name="kyc"></param>
        /// <param name="configurationSchema"></param>
        /// <param name="allowedUpdates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningServicesResponseDataItem(
            string id,
            string description,
            global::System.Collections.Generic.IList<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemCategorie> categories,
            global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant1, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant2, global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemPricingVariant3> pricing,
            global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemKind? kind,
            string? group,
            global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemKyc? kyc,
            global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemConfigurationSchema? configurationSchema,
            global::System.Collections.Generic.IList<string>? allowedUpdates)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.Kind = kind;
            this.Pricing = pricing;
            this.Group = group;
            this.Kyc = kyc;
            this.ConfigurationSchema = configurationSchema;
            this.AllowedUpdates = allowedUpdates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItem" /> class.
        /// </summary>
        public GetAgenticProvisioningServicesResponseDataItem()
        {
        }
    }
}