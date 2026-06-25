
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role?, string> Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1ScopeJsonConverter))]
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Scope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="role"></param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1(
            string enabled,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role?, string> role,
            global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Scope? scope)
        {
            this.Enabled = enabled;
            this.Role = role;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1()
        {
        }

    }
}