
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1ScopeJsonConverter))]
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Scope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="scope"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1(
            global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role role,
            global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Scope? scope,
            string enabled = "True")
        {
            this.Enabled = enabled;
            this.Role = role;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1" /> class.
        /// </summary>
        public GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1 FromRole(global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role role)
        {
            return new GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1
            {
                Role = role,
            };
        }

    }
}