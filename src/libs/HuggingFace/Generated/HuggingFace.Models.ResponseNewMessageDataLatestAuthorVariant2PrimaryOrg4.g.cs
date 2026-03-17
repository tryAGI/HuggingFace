
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseNewMessageDataLatestAuthorVariant2PrimaryOrg4
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("isFollowing")]
        public bool? IsFollowing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan4JsonConverter))]
        public global::HuggingFace.ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan4? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasPrivateMembersList")]
        public bool? HasPrivateMembersList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userRole")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole4JsonConverter))]
        public global::HuggingFace.ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole4? UserRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numUsers")]
        public double? NumUsers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNewMessageDataLatestAuthorVariant2PrimaryOrg4" /> class.
        /// </summary>
        /// <param name="avatarUrl"></param>
        /// <param name="fullname"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="isHf"></param>
        /// <param name="isFollowing"></param>
        /// <param name="plan"></param>
        /// <param name="details"></param>
        /// <param name="hasPrivateMembersList"></param>
        /// <param name="userRole"></param>
        /// <param name="numUsers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseNewMessageDataLatestAuthorVariant2PrimaryOrg4(
            string avatarUrl,
            string fullname,
            string name,
            bool isHf,
            bool? isFollowing,
            global::HuggingFace.ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan4? plan,
            string? details,
            bool? hasPrivateMembersList,
            global::HuggingFace.ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole4? userRole,
            double? numUsers,
            string type = "org")
        {
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Fullname = fullname ?? throw new global::System.ArgumentNullException(nameof(fullname));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsHf = isHf;
            this.Type = type;
            this.IsFollowing = isFollowing;
            this.Plan = plan;
            this.Details = details;
            this.HasPrivateMembersList = hasPrivateMembersList;
            this.UserRole = userRole;
            this.NumUsers = numUsers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNewMessageDataLatestAuthorVariant2PrimaryOrg4" /> class.
        /// </summary>
        public ResponseNewMessageDataLatestAuthorVariant2PrimaryOrg4()
        {
        }
    }
}