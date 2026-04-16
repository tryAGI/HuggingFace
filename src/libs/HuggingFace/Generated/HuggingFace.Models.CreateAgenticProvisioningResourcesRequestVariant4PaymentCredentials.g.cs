
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesRequestVariant4PaymentCredentials
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"stripe_payment_token"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "stripe_payment_token";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_payment_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StripePaymentToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant4PaymentCredentials" /> class.
        /// </summary>
        /// <param name="stripePaymentToken"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesRequestVariant4PaymentCredentials(
            string stripePaymentToken,
            string type = "stripe_payment_token")
        {
            this.Type = type;
            this.StripePaymentToken = stripePaymentToken ?? throw new global::System.ArgumentNullException(nameof(stripePaymentToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant4PaymentCredentials" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesRequestVariant4PaymentCredentials()
        {
        }
    }
}