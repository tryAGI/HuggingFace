
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsSettingsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoJoin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant2>? AutoJoin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spendLimits")]
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseSpendLimits? SpendLimits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseUser> Users { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant2, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant3, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant4, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant5>> Resources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="users"></param>
        /// <param name="resources"></param>
        /// <param name="description"></param>
        /// <param name="autoJoin"></param>
        /// <param name="spendLimits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsSettingsResponse(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseUser> users,
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant2, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant3, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant4, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant5>> resources,
            string? description,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant2>? autoJoin,
            global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseSpendLimits? spendLimits)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.AutoJoin = autoJoin;
            this.SpendLimits = spendLimits;
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsResponse" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsSettingsResponse()
        {
        }

    }
}