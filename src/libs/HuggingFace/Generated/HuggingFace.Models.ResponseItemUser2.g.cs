
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemUser2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("orgs")]
        public global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemUserOrg>? Orgs { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("numModels")]
        public double? NumModels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numDatasets")]
        public double? NumDatasets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numSpaces")]
        public double? NumSpaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numDiscussions")]
        public double? NumDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numPapers")]
        public double? NumPapers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numUpvotes")]
        public double? NumUpvotes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numLikes")]
        public double? NumLikes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numFollowers")]
        public double? NumFollowers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numFollowing")]
        public double? NumFollowing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFollowing")]
        public bool? IsFollowing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasonToFollow")]
        public string? ReasonToFollow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemUser2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="orgs"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="fullname"></param>
        /// <param name="isPro"></param>
        /// <param name="user"></param>
        /// <param name="numModels"></param>
        /// <param name="numDatasets"></param>
        /// <param name="numSpaces"></param>
        /// <param name="numDiscussions"></param>
        /// <param name="numPapers"></param>
        /// <param name="numUpvotes"></param>
        /// <param name="numLikes"></param>
        /// <param name="numFollowers"></param>
        /// <param name="numFollowing"></param>
        /// <param name="details"></param>
        /// <param name="isFollowing"></param>
        /// <param name="reasonToFollow"></param>
        /// <param name="type"></param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemUser2(
            string id,
            string avatarUrl,
            string fullname,
            bool isPro,
            string user,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemUserOrg>? orgs,
            double? numModels,
            double? numDatasets,
            double? numSpaces,
            double? numDiscussions,
            double? numPapers,
            double? numUpvotes,
            double? numLikes,
            double? numFollowers,
            double? numFollowing,
            string? details,
            bool? isFollowing,
            string? reasonToFollow,
            string? email,
            string type = "user")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Fullname = fullname ?? throw new global::System.ArgumentNullException(nameof(fullname));
            this.IsPro = isPro;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Orgs = orgs;
            this.NumModels = numModels;
            this.NumDatasets = numDatasets;
            this.NumSpaces = numSpaces;
            this.NumDiscussions = numDiscussions;
            this.NumPapers = numPapers;
            this.NumUpvotes = numUpvotes;
            this.NumLikes = numLikes;
            this.NumFollowers = numFollowers;
            this.NumFollowing = numFollowing;
            this.Details = details;
            this.IsFollowing = isFollowing;
            this.ReasonToFollow = reasonToFollow;
            this.Type = type;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemUser2" /> class.
        /// </summary>
        public ResponseItemUser2()
        {
        }
    }
}