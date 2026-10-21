
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsSettingsResponse2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minRoleToCreate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate MinRoleToCreate { get; set; }

        /// <summary>
        /// Whether resource group admins may invite users from outside the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowExternalInvites")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowExternalInvites { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsResponse2" /> class.
        /// </summary>
        /// <param name="minRoleToCreate"></param>
        /// <param name="allowExternalInvites">
        /// Whether resource group admins may invite users from outside the organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsSettingsResponse2(
            global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate minRoleToCreate,
            bool allowExternalInvites)
        {
            this.MinRoleToCreate = minRoleToCreate;
            this.AllowExternalInvites = allowExternalInvites;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsResponse2" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsSettingsResponse2()
        {
        }

    }
}