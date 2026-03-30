
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningAccountRequestsResponseVariant1CredentialsBearerAccount
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
        /// <default>"orchestrator"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_credentials")]
        public string PaymentCredentials { get; set; } = "orchestrator";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsResponseVariant1CredentialsBearerAccount" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="paymentCredentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningAccountRequestsResponseVariant1CredentialsBearerAccount(
            string id,
            string paymentCredentials = "orchestrator")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PaymentCredentials = paymentCredentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsResponseVariant1CredentialsBearerAccount" /> class.
        /// </summary>
        public CreateAgenticProvisioningAccountRequestsResponseVariant1CredentialsBearerAccount()
        {
        }
    }
}