
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateOrganizationsServiceAccountsTokensRequest
    {
        /// <summary>
        /// Display name for the token<br/>
        /// Default Value: API Token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Org-wide permissions for this token<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission>? Permissions { get; set; }

        /// <summary>
        /// Repositories to grant `repoPermissions` on. Can be repositories owned by the organization or any public repository. These override the org-wide permissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoIds")]
        public global::System.Collections.Generic.IList<string>? RepoIds { get; set; }

        /// <summary>
        /// Permissions granted on the selected `repoIds`.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoPermissions")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission>? RepoPermissions { get; set; }

        /// <summary>
        /// Inference endpoint name patterns (wildcards allowed, e.g. `gpt2-*`) restricting the token's org-wide Inference Endpoint permissions to matching endpoints. Empty means all endpoints.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointPatterns")]
        public global::System.Collections.Generic.IList<string>? EndpointPatterns { get; set; }

        /// <summary>
        /// Exempt this token from the org's Network Security enforcement (IP allowlist and content access policy). Enterprise Plus only, and requires the `org.networkSecurity.write` permission.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipNetworkSecurity")]
        public bool? SkipNetworkSecurity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsServiceAccountsTokensRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Display name for the token<br/>
        /// Default Value: API Token
        /// </param>
        /// <param name="permissions">
        /// Org-wide permissions for this token<br/>
        /// Default Value: []
        /// </param>
        /// <param name="repoIds">
        /// Repositories to grant `repoPermissions` on. Can be repositories owned by the organization or any public repository. These override the org-wide permissions.
        /// </param>
        /// <param name="repoPermissions">
        /// Permissions granted on the selected `repoIds`.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="endpointPatterns">
        /// Inference endpoint name patterns (wildcards allowed, e.g. `gpt2-*`) restricting the token's org-wide Inference Endpoint permissions to matching endpoints. Empty means all endpoints.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="skipNetworkSecurity">
        /// Exempt this token from the org's Network Security enforcement (IP allowlist and content access policy). Enterprise Plus only, and requires the `org.networkSecurity.write` permission.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsServiceAccountsTokensRequest(
            string? displayName,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission>? permissions,
            global::System.Collections.Generic.IList<string>? repoIds,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission>? repoPermissions,
            global::System.Collections.Generic.IList<string>? endpointPatterns,
            bool? skipNetworkSecurity)
        {
            this.DisplayName = displayName;
            this.Permissions = permissions;
            this.RepoIds = repoIds;
            this.RepoPermissions = repoPermissions;
            this.EndpointPatterns = endpointPatterns;
            this.SkipNetworkSecurity = skipNetworkSecurity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsServiceAccountsTokensRequest" /> class.
        /// </summary>
        public CreateOrganizationsServiceAccountsTokensRequest()
        {
        }

    }
}