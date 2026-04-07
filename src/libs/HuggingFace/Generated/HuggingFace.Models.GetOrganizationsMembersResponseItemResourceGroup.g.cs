
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsMembersResponseItemResourceGroup
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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numUsers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroupRole?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroupRole?, string> Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsMembersResponseItemResourceGroup" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="numUsers"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsMembersResponseItemResourceGroup(
            string name,
            string id,
            double numUsers,
            global::HuggingFace.AnyOf<global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroupRole?, string> role)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NumUsers = numUsers;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsMembersResponseItemResourceGroup" /> class.
        /// </summary>
        public GetOrganizationsMembersResponseItemResourceGroup()
        {
        }
    }
}