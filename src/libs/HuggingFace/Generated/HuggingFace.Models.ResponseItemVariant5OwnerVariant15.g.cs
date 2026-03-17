
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemVariant5OwnerVariant15
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
        /// <default>"org"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "org";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemVariant5OwnerVariant1Plan5JsonConverter))]
        public global::HuggingFace.ResponseItemVariant5OwnerVariant1Plan5? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isUserFollowing")]
        public bool? IsUserFollowing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant5OwnerVariant15" /> class.
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
        /// <param name="plan"></param>
        /// <param name="isUserFollowing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemVariant5OwnerVariant15(
            string id,
            string avatarUrl,
            string fullname,
            string name,
            bool isHf,
            bool isHfAdmin,
            bool isMod,
            double? followerCount,
            global::HuggingFace.ResponseItemVariant5OwnerVariant1Plan5? plan,
            bool? isUserFollowing,
            string type = "org")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Fullname = fullname ?? throw new global::System.ArgumentNullException(nameof(fullname));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsHf = isHf;
            this.IsHfAdmin = isHfAdmin;
            this.IsMod = isMod;
            this.FollowerCount = followerCount;
            this.Type = type;
            this.Plan = plan;
            this.IsUserFollowing = isUserFollowing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant5OwnerVariant15" /> class.
        /// </summary>
        public ResponseItemVariant5OwnerVariant15()
        {
        }
    }
}