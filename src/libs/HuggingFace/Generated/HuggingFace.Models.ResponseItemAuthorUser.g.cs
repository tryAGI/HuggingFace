
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// User overview information
    /// </summary>
    public sealed partial class ResponseItemAuthorUser
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
        [global::System.Text.Json.Serialization.JsonPropertyName("isPro")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isHf")]
        public bool? IsHf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isHfAdmin")]
        public bool? IsHfAdmin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMod")]
        public bool? IsMod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followerCount")]
        public double? FollowerCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemAuthorUser" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="fullname"></param>
        /// <param name="isPro"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="user"></param>
        /// <param name="isHf"></param>
        /// <param name="isHfAdmin"></param>
        /// <param name="isMod"></param>
        /// <param name="followerCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemAuthorUser(
            string id,
            string avatarUrl,
            string fullname,
            bool isPro,
            string name,
            string type,
            string? user,
            bool? isHf,
            bool? isHfAdmin,
            bool? isMod,
            double? followerCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Fullname = fullname ?? throw new global::System.ArgumentNullException(nameof(fullname));
            this.IsPro = isPro;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.User = user;
            this.IsHf = isHf;
            this.IsHfAdmin = isHfAdmin;
            this.IsMod = isMod;
            this.FollowerCount = followerCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemAuthorUser" /> class.
        /// </summary>
        public ResponseItemAuthorUser()
        {
        }
    }
}