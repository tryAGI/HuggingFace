
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsServiceAccountsResponseAccessToken
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
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsedAt")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        public global::System.DateTime? Expiration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsServiceAccountsResponseAccessTokenRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission>? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last4")]
        public string? Last4 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsServiceAccountsResponseAccessToken" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="createdAt"></param>
        /// <param name="role"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="expiration"></param>
        /// <param name="permissions"></param>
        /// <param name="last4"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsServiceAccountsResponseAccessToken(
            string id,
            string displayName,
            global::System.DateTime createdAt,
            global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRole role,
            global::System.DateTime? lastUsedAt,
            global::System.DateTime? expiration,
            global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission>? permissions,
            string? last4)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.CreatedAt = createdAt;
            this.LastUsedAt = lastUsedAt;
            this.Expiration = expiration;
            this.Role = role;
            this.Permissions = permissions;
            this.Last4 = last4;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsServiceAccountsResponseAccessToken" /> class.
        /// </summary>
        public GetOrganizationsServiceAccountsResponseAccessToken()
        {
        }

    }
}