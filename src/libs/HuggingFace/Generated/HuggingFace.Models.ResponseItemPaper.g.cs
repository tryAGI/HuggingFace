
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Paper data with metadata
    /// </summary>
    public sealed partial class ResponseItemPaper
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
        [global::System.Text.Json.Serialization.JsonPropertyName("authors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemPaperAuthor> Authors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaUrls")]
        public global::System.Collections.Generic.IList<string>? MediaUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedOnDailyAt")]
        public global::System.DateTime? SubmittedOnDailyAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// User overview information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedOnDailyBy")]
        public global::HuggingFace.ResponseItemPaperSubmittedOnDailyBy? SubmittedOnDailyBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upvotes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Upvotes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withdrawnAt")]
        public global::System.DateTime? WithdrawnAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiscussionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectPage")]
        public string? ProjectPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("githubRepo")]
        public string? GithubRepo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_summary")]
        public string? AiSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_keywords")]
        public global::System.Collections.Generic.IList<string>? AiKeywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("githubStars")]
        public double? GithubStars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemPaper" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="authors"></param>
        /// <param name="mediaUrls"></param>
        /// <param name="publishedAt"></param>
        /// <param name="submittedOnDailyAt"></param>
        /// <param name="title"></param>
        /// <param name="submittedOnDailyBy">
        /// User overview information
        /// </param>
        /// <param name="summary"></param>
        /// <param name="upvotes"></param>
        /// <param name="withdrawnAt"></param>
        /// <param name="discussionId"></param>
        /// <param name="projectPage"></param>
        /// <param name="githubRepo"></param>
        /// <param name="aiSummary"></param>
        /// <param name="aiKeywords"></param>
        /// <param name="githubStars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemPaper(
            string id,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemPaperAuthor> authors,
            global::System.DateTime publishedAt,
            string title,
            string summary,
            double upvotes,
            string discussionId,
            global::System.Collections.Generic.IList<string>? mediaUrls,
            global::System.DateTime? submittedOnDailyAt,
            global::HuggingFace.ResponseItemPaperSubmittedOnDailyBy? submittedOnDailyBy,
            global::System.DateTime? withdrawnAt,
            string? projectPage,
            string? githubRepo,
            string? aiSummary,
            global::System.Collections.Generic.IList<string>? aiKeywords,
            double? githubStars)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Authors = authors ?? throw new global::System.ArgumentNullException(nameof(authors));
            this.PublishedAt = publishedAt;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Upvotes = upvotes;
            this.DiscussionId = discussionId ?? throw new global::System.ArgumentNullException(nameof(discussionId));
            this.MediaUrls = mediaUrls;
            this.SubmittedOnDailyAt = submittedOnDailyAt;
            this.SubmittedOnDailyBy = submittedOnDailyBy;
            this.WithdrawnAt = withdrawnAt;
            this.ProjectPage = projectPage;
            this.GithubRepo = githubRepo;
            this.AiSummary = aiSummary;
            this.AiKeywords = aiKeywords;
            this.GithubStars = githubStars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemPaper" /> class.
        /// </summary>
        public ResponseItemPaper()
        {
        }
    }
}