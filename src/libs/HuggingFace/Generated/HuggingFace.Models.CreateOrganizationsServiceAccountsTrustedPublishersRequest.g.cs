
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateOrganizationsServiceAccountsTrustedPublishersRequest
    {
        /// <summary>
        /// URL of the OIDC issuer, e.g. `https://token.actions.githubusercontent.com`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuerUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuerUrl { get; set; }

        /// <summary>
        /// Claims the OIDC token must match, by claim name. At least one is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Claims { get; set; }

        /// <summary>
        /// Scopes granted to matching tokens on top of `gated-repos` (read the gated repos the account has access to).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTrustedPublishersRequestCapabilitie>? Capabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsServiceAccountsTrustedPublishersRequest" /> class.
        /// </summary>
        /// <param name="issuerUrl">
        /// URL of the OIDC issuer, e.g. `https://token.actions.githubusercontent.com`.
        /// </param>
        /// <param name="claims">
        /// Claims the OIDC token must match, by claim name. At least one is required.
        /// </param>
        /// <param name="capabilities">
        /// Scopes granted to matching tokens on top of `gated-repos` (read the gated repos the account has access to).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsServiceAccountsTrustedPublishersRequest(
            string issuerUrl,
            object claims,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTrustedPublishersRequestCapabilitie>? capabilities)
        {
            this.IssuerUrl = issuerUrl ?? throw new global::System.ArgumentNullException(nameof(issuerUrl));
            this.Claims = claims ?? throw new global::System.ArgumentNullException(nameof(claims));
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsServiceAccountsTrustedPublishersRequest" /> class.
        /// </summary>
        public CreateOrganizationsServiceAccountsTrustedPublishersRequest()
        {
        }

    }
}