
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsUsersResponse
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant2>? AutoJoin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseUser> Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseRepo> Repos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsUsersResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="users"></param>
        /// <param name="repos"></param>
        /// <param name="description"></param>
        /// <param name="autoJoin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsUsersResponse(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseUser> users,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseRepo> repos,
            string? description,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant2>? autoJoin)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.AutoJoin = autoJoin;
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Repos = repos ?? throw new global::System.ArgumentNullException(nameof(repos));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsUsersResponse" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsUsersResponse()
        {
        }

    }
}