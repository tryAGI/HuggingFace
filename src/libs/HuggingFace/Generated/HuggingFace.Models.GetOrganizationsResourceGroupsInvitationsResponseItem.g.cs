
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// A pending organization invitation
    /// </summary>
    public sealed partial class GetOrganizationsResourceGroupsInvitationsResponseItem
    {
        /// <summary>
        /// A hex string of 24 characters representing an ObjectId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Organization role the invitee joins with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsResourceGroupsInvitationsResponseItemRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemRole Role { get; set; }

        /// <summary>
        /// Whether the invitee is exempted from SSO enforcement
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalCollaborator")]
        public bool? ExternalCollaborator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// The user who issued the invitation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemAuthor? Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitee")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemInvitee Invitee { get; set; }

        /// <summary>
        /// Set when the invitation only grants access to one resource group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroup")]
        public global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemResourceGroup? ResourceGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsResourceGroupsInvitationsResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// A hex string of 24 characters representing an ObjectId.
        /// </param>
        /// <param name="role">
        /// Organization role the invitee joins with
        /// </param>
        /// <param name="expiresAt"></param>
        /// <param name="invitee"></param>
        /// <param name="externalCollaborator">
        /// Whether the invitee is exempted from SSO enforcement
        /// </param>
        /// <param name="author">
        /// The user who issued the invitation
        /// </param>
        /// <param name="resourceGroup">
        /// Set when the invitation only grants access to one resource group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsResourceGroupsInvitationsResponseItem(
            string id,
            global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemRole role,
            global::System.DateTime expiresAt,
            global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemInvitee invitee,
            bool? externalCollaborator,
            global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemAuthor? author,
            global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemResourceGroup? resourceGroup)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
            this.ExternalCollaborator = externalCollaborator;
            this.ExpiresAt = expiresAt;
            this.Author = author;
            this.Invitee = invitee ?? throw new global::System.ArgumentNullException(nameof(invitee));
            this.ResourceGroup = resourceGroup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsResourceGroupsInvitationsResponseItem" /> class.
        /// </summary>
        public GetOrganizationsResourceGroupsInvitationsResponseItem()
        {
        }

    }
}