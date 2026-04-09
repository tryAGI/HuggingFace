
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// SCIM. Use the SCIM API to control and manage your hub Enterprise organization manage members' access.<br/>
    /// ## Authentication<br/>
    /// - Must be organization owner<br/>
    /// - Use Access token with write permission on organization<br/>
    /// - Organization must be Enterprise Plus<br/>
    /// ## Key Attribute Matching<br/>
    /// - Microsoft Entra ID (Azure AD)<br/>
    /// 	* SAML: `http://schemas.microsoft.com/identity/claims/objectidentifier`<br/>
    /// 	* SCIM: `externalId`<br/>
    /// - Other Identity Providers<br/>
    /// 	* SAML: `NameID` or `unique identifier`<br/>
    /// 	* SCIM: `externalId`<br/>
    /// ## Supported SCIM User Attributes<br/>
    /// | Attribute | Description |<br/>
    /// |---|---|<br/>
    /// | `userName` | Username for the user |<br/>
    /// | `name.givenName` | First name |<br/>
    /// | `name.familyName` | Last name |<br/>
    /// | `emails` | Array of user emails; we don't support email types |<br/>
    /// | `externalId` | IDP provider's unique identifier |<br/>
    /// | `id` | Hugging Face SCIM endpoint identifier |<br/>
    /// | `active` | Boolean for provisioning status |.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IScimClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}