
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSettingsTrustedPublishersRequest
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
        /// Permissions granted on the repo to matching tokens. Defaults to `["repo.content.write"]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsTrustedPublishersRequestPermission>? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsTrustedPublishersRequest" /> class.
        /// </summary>
        /// <param name="issuerUrl">
        /// URL of the OIDC issuer, e.g. `https://token.actions.githubusercontent.com`.
        /// </param>
        /// <param name="claims">
        /// Claims the OIDC token must match, by claim name. At least one is required.
        /// </param>
        /// <param name="permissions">
        /// Permissions granted on the repo to matching tokens. Defaults to `["repo.content.write"]`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsTrustedPublishersRequest(
            string issuerUrl,
            object claims,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsTrustedPublishersRequestPermission>? permissions)
        {
            this.IssuerUrl = issuerUrl ?? throw new global::System.ArgumentNullException(nameof(issuerUrl));
            this.Claims = claims ?? throw new global::System.ArgumentNullException(nameof(claims));
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsTrustedPublishersRequest" /> class.
        /// </summary>
        public CreateSettingsTrustedPublishersRequest()
        {
        }

    }
}