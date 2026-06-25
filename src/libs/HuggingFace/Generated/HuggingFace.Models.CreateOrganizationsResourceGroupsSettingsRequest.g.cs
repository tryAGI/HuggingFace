
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsSettingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoJoin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant2>? AutoJoin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsRequest" /> class.
        /// </summary>
        /// <param name="autoJoin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsSettingsRequest(
            global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant2>? autoJoin)
        {
            this.AutoJoin = autoJoin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsRequest" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsSettingsRequest()
        {
        }

    }
}