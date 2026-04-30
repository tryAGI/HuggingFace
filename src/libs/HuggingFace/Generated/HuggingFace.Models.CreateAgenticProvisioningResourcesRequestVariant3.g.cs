
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesRequestVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"free"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = "free";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant3Configuration? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_credentials")]
        public global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant3PaymentCredentials? PaymentCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant3" /> class.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="paymentCredentials"></param>
        /// <param name="serviceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesRequestVariant3(
            global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant3Configuration? configuration,
            global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant3PaymentCredentials? paymentCredentials,
            string serviceId = "free")
        {
            this.ServiceId = serviceId;
            this.Configuration = configuration;
            this.PaymentCredentials = paymentCredentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant3" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesRequestVariant3()
        {
        }
    }
}