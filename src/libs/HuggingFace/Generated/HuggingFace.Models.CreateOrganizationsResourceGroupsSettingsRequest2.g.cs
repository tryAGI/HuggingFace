
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsSettingsRequest2
    {
        /// <summary>
        /// Minimum organization role required to create a resource group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minRoleToCreate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreateJsonConverter))]
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate? MinRoleToCreate { get; set; }

        /// <summary>
        /// Whether resource group admins may invite users from outside the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowExternalInvites")]
        public string? AllowExternalInvites { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsRequest2" /> class.
        /// </summary>
        /// <param name="minRoleToCreate">
        /// Minimum organization role required to create a resource group
        /// </param>
        /// <param name="allowExternalInvites">
        /// Whether resource group admins may invite users from outside the organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsSettingsRequest2(
            global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate? minRoleToCreate,
            string? allowExternalInvites)
        {
            this.MinRoleToCreate = minRoleToCreate;
            this.AllowExternalInvites = allowExternalInvites;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsRequest2" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsSettingsRequest2()
        {
        }

    }
}