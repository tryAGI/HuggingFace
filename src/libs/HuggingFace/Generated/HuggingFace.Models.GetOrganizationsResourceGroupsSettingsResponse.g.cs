
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationsResourceGroupsSettingsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minRoleToCreate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate MinRoleToCreate { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="GetOrganizationsResourceGroupsSettingsResponse" /> class.
        /// </summary>
        /// <param name="minRoleToCreate"></param>
        /// <param name="allowExternalInvites"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsResourceGroupsSettingsResponse(
            global::HuggingFace.GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate minRoleToCreate,
            bool allowExternalInvites)
        {
            this.MinRoleToCreate = minRoleToCreate;
            this.AllowExternalInvites = allowExternalInvites;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsResourceGroupsSettingsResponse" /> class.
        /// </summary>
        public GetOrganizationsResourceGroupsSettingsResponse()
        {
        }

    }
}