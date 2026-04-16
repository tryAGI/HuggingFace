
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesUpdateServiceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceRequestConfiguration? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_credentials")]
        public global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceRequestPaymentCredentials? PaymentCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesUpdateServiceRequest" /> class.
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="configuration"></param>
        /// <param name="paymentCredentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesUpdateServiceRequest(
            string? serviceId,
            global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceRequestConfiguration? configuration,
            global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceRequestPaymentCredentials? paymentCredentials)
        {
            this.ServiceId = serviceId;
            this.Configuration = configuration;
            this.PaymentCredentials = paymentCredentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesUpdateServiceRequest" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesUpdateServiceRequest()
        {
        }
    }
}