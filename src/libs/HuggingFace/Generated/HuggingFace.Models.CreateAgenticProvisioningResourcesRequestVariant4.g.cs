
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesRequestVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"pay_as_you_go"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = "pay_as_you_go";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant4Configuration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_credentials")]
        public global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant4PaymentCredentials? PaymentCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant4" /> class.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="paymentCredentials"></param>
        /// <param name="serviceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesRequestVariant4(
            global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant4Configuration configuration,
            global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant4PaymentCredentials? paymentCredentials,
            string serviceId = "pay_as_you_go")
        {
            this.ServiceId = serviceId;
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.PaymentCredentials = paymentCredentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant4" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesRequestVariant4()
        {
        }
    }
}