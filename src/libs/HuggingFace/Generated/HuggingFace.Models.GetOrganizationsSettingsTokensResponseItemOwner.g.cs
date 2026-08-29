
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Organization member the token belongs to
    /// </summary>
    public sealed partial class GetOrganizationsSettingsTokensResponseItemOwner
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Username of the member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fullname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsTokensResponseItemOwner" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// Username of the member
        /// </param>
        /// <param name="fullname"></param>
        /// <param name="avatarUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsSettingsTokensResponseItemOwner(
            string id,
            string name,
            string fullname,
            string avatarUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Fullname = fullname ?? throw new global::System.ArgumentNullException(nameof(fullname));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsTokensResponseItemOwner" /> class.
        /// </summary>
        public GetOrganizationsSettingsTokensResponseItemOwner()
        {
        }

    }
}