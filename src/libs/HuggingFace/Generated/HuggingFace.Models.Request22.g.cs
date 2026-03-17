
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request22
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uris")]
        public global::System.Collections.Generic.IList<string>? RedirectUris { get; set; }

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
        public string? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contacts")]
        public global::System.Collections.Generic.IList<string>? Contacts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.RequestTokenEndpointAuthMethodJsonConverter))]
        public global::HuggingFace.RequestTokenEndpointAuthMethod? TokenEndpointAuthMethod { get; set; }

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
        /// Initializes a new instance of the <see cref="Request22" /> class.
        /// </summary>
        /// <param name="redirectUris"></param>
        /// <param name="clientName"></param>
        /// <param name="clientUri"></param>
        /// <param name="logoUri"></param>
        /// <param name="scope"></param>
        /// <param name="contacts"></param>
        /// <param name="tokenEndpointAuthMethod"></param>
        /// <param name="softwareId"></param>
        /// <param name="softwareVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request22(
            global::System.Collections.Generic.IList<string>? redirectUris,
            string? clientName,
            string? clientUri,
            string? logoUri,
            string? scope,
            global::System.Collections.Generic.IList<string>? contacts,
            global::HuggingFace.RequestTokenEndpointAuthMethod? tokenEndpointAuthMethod,
            string? softwareId,
            string? softwareVersion)
        {
            this.RedirectUris = redirectUris;
            this.ClientName = clientName;
            this.ClientUri = clientUri;
            this.LogoUri = logoUri;
            this.Scope = scope;
            this.Contacts = contacts;
            this.TokenEndpointAuthMethod = tokenEndpointAuthMethod;
            this.SoftwareId = softwareId;
            this.SoftwareVersion = softwareVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request22" /> class.
        /// </summary>
        public Request22()
        {
        }
    }
}