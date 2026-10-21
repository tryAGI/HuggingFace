
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsInviteRequest
    {
        /// <summary>
        /// Username of an existing Hugging Face user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Role the invitee gets inside the resource group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateOrganizationsResourceGroupsInviteRequestRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateOrganizationsResourceGroupsInviteRequestRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsInviteRequest" /> class.
        /// </summary>
        /// <param name="username">
        /// Username of an existing Hugging Face user
        /// </param>
        /// <param name="role">
        /// Role the invitee gets inside the resource group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsInviteRequest(
            string username,
            global::HuggingFace.CreateOrganizationsResourceGroupsInviteRequestRole role)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsInviteRequest" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsInviteRequest()
        {
        }

    }
}