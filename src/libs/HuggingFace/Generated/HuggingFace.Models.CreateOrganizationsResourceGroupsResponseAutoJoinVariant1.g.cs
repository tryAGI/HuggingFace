
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsResponseAutoJoinVariant1
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1ScopeJsonConverter))]
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsResponseAutoJoinVariant1" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="scope"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsResponseAutoJoinVariant1(
            global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role role,
            global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? scope,
            string enabled = "True")
        {
            this.Enabled = enabled;
            this.Role = role;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsResponseAutoJoinVariant1" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsResponseAutoJoinVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateOrganizationsResourceGroupsResponseAutoJoinVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateOrganizationsResourceGroupsResponseAutoJoinVariant1 FromRole(global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role role)
        {
            return new CreateOrganizationsResourceGroupsResponseAutoJoinVariant1
            {
                Role = role,
            };
        }

    }
}