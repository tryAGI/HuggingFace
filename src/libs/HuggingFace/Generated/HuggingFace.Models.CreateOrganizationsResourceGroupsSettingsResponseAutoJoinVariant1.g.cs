
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"True"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public string Enabled { get; set; } = "True";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1ScopeJsonConverter))]
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Scope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="scope"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1(
            global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role role,
            global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Scope? scope,
            string enabled = "True")
        {
            this.Enabled = enabled;
            this.Role = role;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1 FromRole(global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role role)
        {
            return new CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1
            {
                Role = role,
            };
        }

    }
}