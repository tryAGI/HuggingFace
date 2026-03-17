
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fullname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isHf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsHf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isHfAdmin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsHfAdmin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsMod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followerCount")]
        public double? FollowerCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPro")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isUserFollowing")]
        public bool? IsUserFollowing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryOrg")]
        public global::HuggingFace.ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrg? PrimaryOrg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="fullname"></param>
        /// <param name="name"></param>
        /// <param name="isHf"></param>
        /// <param name="isHfAdmin"></param>
        /// <param name="isMod"></param>
        /// <param name="followerCount"></param>
        /// <param name="type"></param>
        /// <param name="isPro"></param>
        /// <param name="isUserFollowing"></param>
        /// <param name="primaryOrg"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2(
            string id,
            string avatarUrl,
            string fullname,
            string name,
            bool isHf,
            bool isHfAdmin,
            bool isMod,
            bool isPro,
            double? followerCount,
            bool? isUserFollowing,
            global::HuggingFace.ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrg? primaryOrg,
            string type = "user")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Fullname = fullname ?? throw new global::System.ArgumentNullException(nameof(fullname));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsHf = isHf;
            this.IsHfAdmin = isHfAdmin;
            this.IsMod = isMod;
            this.IsPro = isPro;
            this.FollowerCount = followerCount;
            this.Type = type;
            this.IsUserFollowing = isUserFollowing;
            this.PrimaryOrg = primaryOrg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2" /> class.
        /// </summary>
        public ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2()
        {
        }
    }
}