
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Reset the role to the one mapped from SCIM groups
    /// </summary>
    public sealed partial class PatchOrganizationsResourceGroupsUsersRequestVariant2
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("resetToScimRole")]
        public bool ResetToScimRole { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsResourceGroupsUsersRequestVariant2" /> class.
        /// </summary>
        /// <param name="resetToScimRole"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsResourceGroupsUsersRequestVariant2(
            bool resetToScimRole = true)
        {
            this.ResetToScimRole = resetToScimRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsResourceGroupsUsersRequestVariant2" /> class.
        /// </summary>
        public PatchOrganizationsResourceGroupsUsersRequestVariant2()
        {
        }

    }
}