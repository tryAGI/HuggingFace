
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colorFrom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColorFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colorTo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColorTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emoji")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Emoji { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isLikedByUser")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLikedByUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Likes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pinned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"space"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoType")]
        public string RepoType { get; set; } = "space";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdk")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemVariant3SdkJsonConverter))]
        public global::HuggingFace.ResponseItemVariant3Sdk? Sdk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemVariant3Runtime Runtime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originRepo")]
        public global::HuggingFace.ResponseItemVariant3OriginRepo? OriginRepo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_short_description")]
        public string? AiShortDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_category")]
        public string? AiCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trendingScore")]
        public double? TrendingScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroup")]
        public global::HuggingFace.ResponseItemVariant3ResourceGroup? ResourceGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorData")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.ResponseItemVariant3AuthorDataVariant1, global::HuggingFace.ResponseItemVariant3AuthorDataVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.ResponseItemVariant3AuthorDataVariant1, global::HuggingFace.ResponseItemVariant3AuthorDataVariant2>? AuthorData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shortDescription")]
        public string? ShortDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semanticRelevancyScore")]
        public double? SemanticRelevancyScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Featured { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemVariant3VisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemVariant3Visibility Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"space"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "space";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant3" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="colorFrom"></param>
        /// <param name="colorTo"></param>
        /// <param name="createdAt"></param>
        /// <param name="emoji"></param>
        /// <param name="id"></param>
        /// <param name="isLikedByUser"></param>
        /// <param name="lastModified"></param>
        /// <param name="likes"></param>
        /// <param name="pinned"></param>
        /// <param name="private"></param>
        /// <param name="repoType"></param>
        /// <param name="title"></param>
        /// <param name="sdk"></param>
        /// <param name="runtime"></param>
        /// <param name="originRepo"></param>
        /// <param name="aiShortDescription"></param>
        /// <param name="aiCategory"></param>
        /// <param name="trendingScore"></param>
        /// <param name="resourceGroup"></param>
        /// <param name="tags"></param>
        /// <param name="authorData"></param>
        /// <param name="shortDescription"></param>
        /// <param name="semanticRelevancyScore"></param>
        /// <param name="featured"></param>
        /// <param name="visibility"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemVariant3(
            string author,
            string colorFrom,
            string colorTo,
            global::System.DateTime createdAt,
            string emoji,
            string id,
            bool isLikedByUser,
            global::System.DateTime lastModified,
            double likes,
            bool pinned,
            bool @private,
            string title,
            global::HuggingFace.ResponseItemVariant3Runtime runtime,
            global::System.Collections.Generic.IList<string> tags,
            bool featured,
            global::HuggingFace.ResponseItemVariant3Visibility visibility,
            global::HuggingFace.ResponseItemVariant3Sdk? sdk,
            global::HuggingFace.ResponseItemVariant3OriginRepo? originRepo,
            string? aiShortDescription,
            string? aiCategory,
            double? trendingScore,
            global::HuggingFace.ResponseItemVariant3ResourceGroup? resourceGroup,
            global::HuggingFace.AnyOf<global::HuggingFace.ResponseItemVariant3AuthorDataVariant1, global::HuggingFace.ResponseItemVariant3AuthorDataVariant2>? authorData,
            string? shortDescription,
            double? semanticRelevancyScore,
            string repoType = "space",
            string type = "space")
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.ColorFrom = colorFrom ?? throw new global::System.ArgumentNullException(nameof(colorFrom));
            this.ColorTo = colorTo ?? throw new global::System.ArgumentNullException(nameof(colorTo));
            this.CreatedAt = createdAt;
            this.Emoji = emoji ?? throw new global::System.ArgumentNullException(nameof(emoji));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsLikedByUser = isLikedByUser;
            this.LastModified = lastModified;
            this.Likes = likes;
            this.Pinned = pinned;
            this.Private = @private;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Runtime = runtime ?? throw new global::System.ArgumentNullException(nameof(runtime));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Featured = featured;
            this.Visibility = visibility;
            this.RepoType = repoType;
            this.Sdk = sdk;
            this.OriginRepo = originRepo;
            this.AiShortDescription = aiShortDescription;
            this.AiCategory = aiCategory;
            this.TrendingScore = trendingScore;
            this.ResourceGroup = resourceGroup;
            this.AuthorData = authorData;
            this.ShortDescription = shortDescription;
            this.SemanticRelevancyScore = semanticRelevancyScore;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant3" /> class.
        /// </summary>
        public ResponseItemVariant3()
        {
        }
    }
}