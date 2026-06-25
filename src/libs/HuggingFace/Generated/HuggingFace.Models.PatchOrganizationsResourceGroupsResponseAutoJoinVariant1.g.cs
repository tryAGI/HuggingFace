
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role?, string> Role { get; set; }

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
            global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role?, string> role,
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

    }
}