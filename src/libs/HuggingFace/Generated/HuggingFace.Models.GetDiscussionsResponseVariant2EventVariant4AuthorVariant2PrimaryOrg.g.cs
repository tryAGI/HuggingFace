
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrg
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrgPlanJsonConverter))]
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrgPlan? Plan { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrgUserRoleJsonConverter))]
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrgUserRole? UserRole { get; set; }

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
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrg" /> class.
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
        public GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrg(
            string avatarUrl,
            string fullname,
            string name,
            bool isHf,
            bool? isFollowing,
            global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrgPlan? plan,
            string? details,
            bool? hasPrivateMembersList,
            global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrgUserRole? userRole,
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
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrg" /> class.
        /// </summary>
        public GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrg()
        {
        }
    }
}