
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"free"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "free";

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
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant1" /> class.
        /// </summary>
        /// <param name="default"></param>
        /// <param name="parentServiceIds"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant1(
            bool? @default,
            global::System.Collections.Generic.IList<string>? parentServiceIds,
            string type = "free")
        {
            this.Type = type;
            this.Default = @default;
            this.ParentServiceIds = parentServiceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant1" /> class.
        /// </summary>
        public GetAgenticProvisioningServicesResponseDataItemPricingVariant3ComponentOptionVariant1()
        {
        }
    }
}