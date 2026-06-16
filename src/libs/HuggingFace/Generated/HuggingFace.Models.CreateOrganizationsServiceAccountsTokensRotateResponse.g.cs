
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationsServiceAccountsTokensRotateResponse
    {
        /// <summary>
        /// The new access token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateOrganizationsServiceAccountsTokensRotateResponseTokenInfo TokenInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsServiceAccountsTokensRotateResponse" /> class.
        /// </summary>
        /// <param name="token">
        /// The new access token
        /// </param>
        /// <param name="tokenInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsServiceAccountsTokensRotateResponse(
            string token,
            global::HuggingFace.CreateOrganizationsServiceAccountsTokensRotateResponseTokenInfo tokenInfo)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.TokenInfo = tokenInfo ?? throw new global::System.ArgumentNullException(nameof(tokenInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsServiceAccountsTokensRotateResponse" /> class.
        /// </summary>
        public CreateOrganizationsServiceAccountsTokensRotateResponse()
        {
        }

    }
}