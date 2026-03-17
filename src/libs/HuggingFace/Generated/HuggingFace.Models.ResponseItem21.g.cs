
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItem21
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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upvotes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Upvotes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnailUrl")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemAuthor3> Authors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::HuggingFace.ResponseItemOrganization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem21" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="upvotes"></param>
        /// <param name="publishedAt"></param>
        /// <param name="thumbnailUrl"></param>
        /// <param name="authors"></param>
        /// <param name="summary"></param>
        /// <param name="projectPage"></param>
        /// <param name="githubRepo"></param>
        /// <param name="aiSummary"></param>
        /// <param name="organization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItem21(
            string id,
            string title,
            double upvotes,
            global::System.DateTime publishedAt,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemAuthor3> authors,
            string summary,
            string? thumbnailUrl,
            string? projectPage,
            string? githubRepo,
            string? aiSummary,
            global::HuggingFace.ResponseItemOrganization? organization)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Upvotes = upvotes;
            this.PublishedAt = publishedAt;
            this.Authors = authors ?? throw new global::System.ArgumentNullException(nameof(authors));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.ThumbnailUrl = thumbnailUrl;
            this.ProjectPage = projectPage;
            this.GithubRepo = githubRepo;
            this.AiSummary = aiSummary;
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem21" /> class.
        /// </summary>
        public ResponseItem21()
        {
        }
    }
}