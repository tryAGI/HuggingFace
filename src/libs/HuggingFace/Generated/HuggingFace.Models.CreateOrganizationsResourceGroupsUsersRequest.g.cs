
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsUsersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant2>> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsUsersRequest" /> class.
        /// </summary>
        /// <param name="users"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsUsersRequest(
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant2>> users)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsUsersRequest" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsUsersRequest()
        {
        }

    }
}