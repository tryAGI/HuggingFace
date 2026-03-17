
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response45
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id_issued_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ClientIdIssuedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret_expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ClientSecretExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uris")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RedirectUris { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_name")]
        public string? ClientName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_uri")]
        public string? ClientUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scope { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_types")]
        public global::System.Collections.Generic.IList<global::HuggingFace.ResponseGrantType> GrantTypes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contacts")]
        public global::System.Collections.Generic.IList<string>? Contacts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseTokenEndpointAuthMethodJsonConverter))]
        public global::HuggingFace.ResponseTokenEndpointAuthMethod? TokenEndpointAuthMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("software_id")]
        public string? SoftwareId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("software_version")]
        public string? SoftwareVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response45" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="clientIdIssuedAt"></param>
        /// <param name="clientSecretExpiresAt"></param>
        /// <param name="redirectUris"></param>
        /// <param name="clientName"></param>
        /// <param name="clientUri"></param>
        /// <param name="logoUri"></param>
        /// <param name="scope"></param>
        /// <param name="grantTypes">
        /// Included only in responses
        /// </param>
        /// <param name="contacts"></param>
        /// <param name="tokenEndpointAuthMethod"></param>
        /// <param name="softwareId"></param>
        /// <param name="softwareVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response45(
            string clientId,
            double clientIdIssuedAt,
            double clientSecretExpiresAt,
            global::System.Collections.Generic.IList<string> redirectUris,
            string scope,
            string? clientSecret,
            string? clientName,
            string? clientUri,
            string? logoUri,
            global::System.Collections.Generic.IList<string>? contacts,
            global::HuggingFace.ResponseTokenEndpointAuthMethod? tokenEndpointAuthMethod,
            string? softwareId,
            string? softwareVersion,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseGrantType> grantTypes = default!)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientIdIssuedAt = clientIdIssuedAt;
            this.ClientSecretExpiresAt = clientSecretExpiresAt;
            this.RedirectUris = redirectUris ?? throw new global::System.ArgumentNullException(nameof(redirectUris));
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.ClientSecret = clientSecret;
            this.ClientName = clientName;
            this.ClientUri = clientUri;
            this.LogoUri = logoUri;
            this.GrantTypes = grantTypes;
            this.Contacts = contacts;
            this.TokenEndpointAuthMethod = tokenEndpointAuthMethod;
            this.SoftwareId = softwareId;
            this.SoftwareVersion = softwareVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response45" /> class.
        /// </summary>
        public Response45()
        {
        }
    }
}