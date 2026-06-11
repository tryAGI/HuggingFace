
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
        /// Fine-grained permissions for this token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission>? Permissions { get; set; }

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
        /// Fine-grained permissions for this token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsServiceAccountsTokensRequest(
            string? displayName,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission>? permissions)
        {
            this.DisplayName = displayName;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsServiceAccountsTokensRequest" /> class.
        /// </summary>
        public PatchOrganizationsServiceAccountsTokensRequest()
        {
        }

    }
}