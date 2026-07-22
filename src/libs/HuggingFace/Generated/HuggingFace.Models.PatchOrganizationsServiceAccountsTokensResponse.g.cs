
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationsServiceAccountsTokensResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RepoIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoPermissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RepoPermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsServiceAccountsTokensResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="permissions"></param>
        /// <param name="repoIds"></param>
        /// <param name="repoPermissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsServiceAccountsTokensResponse(
            string id,
            string displayName,
            global::System.Collections.Generic.IList<string> permissions,
            global::System.Collections.Generic.IList<string> repoIds,
            global::System.Collections.Generic.IList<string> repoPermissions)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.RepoIds = repoIds ?? throw new global::System.ArgumentNullException(nameof(repoIds));
            this.RepoPermissions = repoPermissions ?? throw new global::System.ArgumentNullException(nameof(repoPermissions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsServiceAccountsTokensResponse" /> class.
        /// </summary>
        public PatchOrganizationsServiceAccountsTokensResponse()
        {
        }

    }
}