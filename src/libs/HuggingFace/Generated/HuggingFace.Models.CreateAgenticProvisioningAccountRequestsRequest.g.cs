
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningAccountRequestsRequest
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
        /// <default>"account_request"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "account_request";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kyc")]
        public global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestKyc? Kyc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestClientCapabilitie> ClientCapabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public object? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmation_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfirmationSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orchestrator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestOrchestrator Orchestrator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="scopes"></param>
        /// <param name="clientCapabilities"></param>
        /// <param name="confirmationSecret"></param>
        /// <param name="expiresAt"></param>
        /// <param name="orchestrator"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="country"></param>
        /// <param name="kyc"></param>
        /// <param name="configuration"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningAccountRequestsRequest(
            string id,
            string email,
            global::System.Collections.Generic.IList<string> scopes,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestClientCapabilitie> clientCapabilities,
            string confirmationSecret,
            global::System.DateTime expiresAt,
            global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestOrchestrator orchestrator,
            string? name,
            string? phone,
            string? country,
            global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestKyc? kyc,
            object? configuration,
            string @object = "account_request")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Name = name;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.Phone = phone;
            this.Country = country;
            this.Kyc = kyc;
            this.ClientCapabilities = clientCapabilities ?? throw new global::System.ArgumentNullException(nameof(clientCapabilities));
            this.Configuration = configuration;
            this.ConfirmationSecret = confirmationSecret ?? throw new global::System.ArgumentNullException(nameof(confirmationSecret));
            this.ExpiresAt = expiresAt;
            this.Orchestrator = orchestrator ?? throw new global::System.ArgumentNullException(nameof(orchestrator));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsRequest" /> class.
        /// </summary>
        public CreateAgenticProvisioningAccountRequestsRequest()
        {
        }
    }
}