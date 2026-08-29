
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsersFollowingOrgsResponseItem
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
        /// <default>"org"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "org";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isHf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsHf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetUsersFollowingOrgsResponseItemOrgTypeJsonConverter))]
        public global::HuggingFace.GetUsersFollowingOrgsResponseItemOrgType? OrgType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetUsersFollowingOrgsResponseItemPlanJsonConverter))]
        public global::HuggingFace.GetUsersFollowingOrgsResponseItemPlan? Plan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFollowing")]
        public bool? IsFollowing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numModels")]
        public double? NumModels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followerCount")]
        public double? FollowerCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasonToFollow")]
        public string? ReasonToFollow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailDomains")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingOrgsResponseItemEmailDomain>? EmailDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersFollowingOrgsResponseItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="name"></param>
        /// <param name="fullname"></param>
        /// <param name="isHf"></param>
        /// <param name="orgType"></param>
        /// <param name="plan"></param>
        /// <param name="isFollowing"></param>
        /// <param name="numModels"></param>
        /// <param name="followerCount"></param>
        /// <param name="reasonToFollow"></param>
        /// <param name="emailDomains"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsersFollowingOrgsResponseItem(
            string id,
            string avatarUrl,
            string name,
            string fullname,
            bool isHf,
            global::HuggingFace.GetUsersFollowingOrgsResponseItemOrgType? orgType,
            global::HuggingFace.GetUsersFollowingOrgsResponseItemPlan? plan,
            bool? isFollowing,
            double? numModels,
            double? followerCount,
            string? reasonToFollow,
            global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingOrgsResponseItemEmailDomain>? emailDomains,
            string type = "org")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Fullname = fullname ?? throw new global::System.ArgumentNullException(nameof(fullname));
            this.Type = type;
            this.IsHf = isHf;
            this.OrgType = orgType;
            this.Plan = plan;
            this.IsFollowing = isFollowing;
            this.NumModels = numModels;
            this.FollowerCount = followerCount;
            this.ReasonToFollow = reasonToFollow;
            this.EmailDomains = emailDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersFollowingOrgsResponseItem" /> class.
        /// </summary>
        public GetUsersFollowingOrgsResponseItem()
        {
        }

    }
}