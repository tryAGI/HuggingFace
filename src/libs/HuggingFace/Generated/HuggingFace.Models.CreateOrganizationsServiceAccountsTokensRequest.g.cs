
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
        /// Fine-grained permissions for this token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission> Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsServiceAccountsTokensRequest" /> class.
        /// </summary>
        /// <param name="permissions">
        /// Fine-grained permissions for this token
        /// </param>
        /// <param name="displayName">
        /// Display name for the token<br/>
        /// Default Value: API Token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsServiceAccountsTokensRequest(
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission> permissions,
            string? displayName)
        {
            this.DisplayName = displayName;
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsServiceAccountsTokensRequest" /> class.
        /// </summary>
        public CreateOrganizationsServiceAccountsTokensRequest()
        {
        }

    }
}