
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsUsersRequestUserVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role?, string> Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsUsersRequestUserVariant1" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsUsersRequestUserVariant1(
            string name,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role?, string> role)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsUsersRequestUserVariant1" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsUsersRequestUserVariant1()
        {
        }

    }
}