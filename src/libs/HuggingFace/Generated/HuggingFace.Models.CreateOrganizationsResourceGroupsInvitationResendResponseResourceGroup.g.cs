
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Set when the invitation only grants access to one resource group
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroup
    {
        /// <summary>
        /// A hex string of 24 characters representing an ObjectId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroupRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroupRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroup" /> class.
        /// </summary>
        /// <param name="id">
        /// A hex string of 24 characters representing an ObjectId.
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroup(
            string id,
            global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroupRole role)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroup" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroup()
        {
        }

    }
}