
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItem4
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
        [global::System.Text.Json.Serialization.JsonPropertyName("isPro")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFollowing")]
        public bool? IsFollowing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemRoleJsonConverter))]
        public global::HuggingFace.ResponseItemRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroups")]
        public global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemResourceGroup>? ResourceGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twoFaEnabled")]
        public bool? TwoFaEnabled { get; set; }

        /// <summary>
        /// The user's SSO email, if the org has a Team or Enterprise plan and the requester is an admin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verifiedEmail")]
        public string? VerifiedEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isExternalCollaborator")]
        public bool? IsExternalCollaborator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem4" /> class.
        /// </summary>
        /// <param name="avatarUrl"></param>
        /// <param name="fullname"></param>
        /// <param name="isPro"></param>
        /// <param name="user"></param>
        /// <param name="type"></param>
        /// <param name="isFollowing"></param>
        /// <param name="id"></param>
        /// <param name="role"></param>
        /// <param name="resourceGroups"></param>
        /// <param name="twoFaEnabled"></param>
        /// <param name="verifiedEmail">
        /// The user's SSO email, if the org has a Team or Enterprise plan and the requester is an admin
        /// </param>
        /// <param name="isExternalCollaborator"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItem4(
            string avatarUrl,
            string fullname,
            bool isPro,
            string user,
            string id,
            bool? isFollowing,
            global::HuggingFace.ResponseItemRole? role,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemResourceGroup>? resourceGroups,
            bool? twoFaEnabled,
            string? verifiedEmail,
            bool? isExternalCollaborator,
            string type = "user")
        {
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Fullname = fullname ?? throw new global::System.ArgumentNullException(nameof(fullname));
            this.IsPro = isPro;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.IsFollowing = isFollowing;
            this.Role = role;
            this.ResourceGroups = resourceGroups;
            this.TwoFaEnabled = twoFaEnabled;
            this.VerifiedEmail = verifiedEmail;
            this.IsExternalCollaborator = isExternalCollaborator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem4" /> class.
        /// </summary>
        public ResponseItem4()
        {
        }
    }
}