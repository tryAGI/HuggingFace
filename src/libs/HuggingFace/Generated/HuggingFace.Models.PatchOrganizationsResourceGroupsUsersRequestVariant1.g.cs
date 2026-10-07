
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchOrganizationsResourceGroupsUsersRequestVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchOrganizationsResourceGroupsUsersRequestVariant1RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequestVariant1Role Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsResourceGroupsUsersRequestVariant1" /> class.
        /// </summary>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsResourceGroupsUsersRequestVariant1(
            global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequestVariant1Role role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsResourceGroupsUsersRequestVariant1" /> class.
        /// </summary>
        public PatchOrganizationsResourceGroupsUsersRequestVariant1()
        {
        }

    }
}