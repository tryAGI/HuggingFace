
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationsServiceAccountsTokensRequest
    {
        /// <summary>
        /// New display name for the token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Org-wide permissions for this token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission>? Permissions { get; set; }

        /// <summary>
        /// Repositories to grant `repoPermissions` on. Can be repositories owned by the organization or any public repository. These override the org-wide permissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoIds")]
        public global::System.Collections.Generic.IList<string>? RepoIds { get; set; }

        /// <summary>
        /// Permissions granted on the selected `repoIds`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoPermissions")]
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission>? RepoPermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsServiceAccountsTokensRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// New display name for the token
        /// </param>
        /// <param name="permissions">
        /// Org-wide permissions for this token
        /// </param>
        /// <param name="repoIds">
        /// Repositories to grant `repoPermissions` on. Can be repositories owned by the organization or any public repository. These override the org-wide permissions.
        /// </param>
        /// <param name="repoPermissions">
        /// Permissions granted on the selected `repoIds`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsServiceAccountsTokensRequest(
            string? displayName,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission>? permissions,
            global::System.Collections.Generic.IList<string>? repoIds,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission>? repoPermissions)
        {
            this.DisplayName = displayName;
            this.Permissions = permissions;
            this.RepoIds = repoIds;
            this.RepoPermissions = repoPermissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsServiceAccountsTokensRequest" /> class.
        /// </summary>
        public PatchOrganizationsServiceAccountsTokensRequest()
        {
        }

    }
}