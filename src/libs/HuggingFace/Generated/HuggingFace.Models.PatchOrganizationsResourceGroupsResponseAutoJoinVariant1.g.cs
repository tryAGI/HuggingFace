
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationsResourceGroupsResponseAutoJoinVariant1
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1ScopeJsonConverter))]
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsResourceGroupsResponseAutoJoinVariant1" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="scope"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsResourceGroupsResponseAutoJoinVariant1(
            global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role role,
            global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? scope,
            string enabled = "True")
        {
            this.Enabled = enabled;
            this.Role = role;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsResourceGroupsResponseAutoJoinVariant1" /> class.
        /// </summary>
        public PatchOrganizationsResourceGroupsResponseAutoJoinVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PatchOrganizationsResourceGroupsResponseAutoJoinVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PatchOrganizationsResourceGroupsResponseAutoJoinVariant1 FromRole(global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role role)
        {
            return new PatchOrganizationsResourceGroupsResponseAutoJoinVariant1
            {
                Role = role,
            };
        }

    }
}