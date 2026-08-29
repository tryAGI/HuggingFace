
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationsSettingsTokensResponseItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name the owner gave the token. Provided when the organization requires administrator approval of member tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Kind of access the token carries. `read` and `write` reach everything their owner can reach, while `fineGrained` is limited to the permissions listed under `fineGrained`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsSettingsTokensResponseItemRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsSettingsTokensResponseItemRole Role { get; set; }

        /// <summary>
        /// Last 4 characters of the token's value, the only part of it ever returned. Absent on tokens created before this was recorded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last4")]
        public string? Last4 { get; set; }

        /// <summary>
        /// Date the token was created, or the date it was last rotated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date the token last authenticated a request. Absent on tokens that have never been used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsedAt")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// Organization member the token belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsSettingsTokensResponseItemOwner Owner { get; set; }

        /// <summary>
        /// Where the token stands in the organization's approval flow. Reported by organizations that require administrator approval of member tokens, and on any token whose access has been revoked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization")]
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorization? Authorization { get; set; }

        /// <summary>
        /// Permissions carried by a `fineGrained` token, narrowed to those that bear on the organization. Absent on `read` and `write` tokens, whose access is not expressed as a permission list, and never covering the account-wide permissions the token may hold elsewhere
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fineGrained")]
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrained? FineGrained { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsTokensResponseItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName">
        /// Name the owner gave the token. Provided when the organization requires administrator approval of member tokens
        /// </param>
        /// <param name="role">
        /// Kind of access the token carries. `read` and `write` reach everything their owner can reach, while `fineGrained` is limited to the permissions listed under `fineGrained`
        /// </param>
        /// <param name="createdAt">
        /// Date the token was created, or the date it was last rotated
        /// </param>
        /// <param name="owner">
        /// Organization member the token belongs to
        /// </param>
        /// <param name="last4">
        /// Last 4 characters of the token's value, the only part of it ever returned. Absent on tokens created before this was recorded
        /// </param>
        /// <param name="lastUsedAt">
        /// Date the token last authenticated a request. Absent on tokens that have never been used
        /// </param>
        /// <param name="authorization">
        /// Where the token stands in the organization's approval flow. Reported by organizations that require administrator approval of member tokens, and on any token whose access has been revoked
        /// </param>
        /// <param name="fineGrained">
        /// Permissions carried by a `fineGrained` token, narrowed to those that bear on the organization. Absent on `read` and `write` tokens, whose access is not expressed as a permission list, and never covering the account-wide permissions the token may hold elsewhere
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsSettingsTokensResponseItem(
            string id,
            string displayName,
            global::HuggingFace.GetOrganizationsSettingsTokensResponseItemRole role,
            global::System.DateTime createdAt,
            global::HuggingFace.GetOrganizationsSettingsTokensResponseItemOwner owner,
            string? last4,
            global::System.DateTime? lastUsedAt,
            global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorization? authorization,
            global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrained? fineGrained)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Role = role;
            this.Last4 = last4;
            this.CreatedAt = createdAt;
            this.LastUsedAt = lastUsedAt;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Authorization = authorization;
            this.FineGrained = fineGrained;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsTokensResponseItem" /> class.
        /// </summary>
        public GetOrganizationsSettingsTokensResponseItem()
        {
        }

    }
}