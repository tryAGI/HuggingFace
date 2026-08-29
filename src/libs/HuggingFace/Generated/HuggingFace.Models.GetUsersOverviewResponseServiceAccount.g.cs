
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Set when the user is a service account
    /// </summary>
    public sealed partial class GetUsersOverviewResponseServiceAccount
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
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgAvatarUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgAvatarUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersOverviewResponseServiceAccount" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="org"></param>
        /// <param name="orgAvatarUrl"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsersOverviewResponseServiceAccount(
            string id,
            string org,
            string orgAvatarUrl,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.OrgAvatarUrl = orgAvatarUrl ?? throw new global::System.ArgumentNullException(nameof(orgAvatarUrl));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersOverviewResponseServiceAccount" /> class.
        /// </summary>
        public GetUsersOverviewResponseServiceAccount()
        {
        }

    }
}