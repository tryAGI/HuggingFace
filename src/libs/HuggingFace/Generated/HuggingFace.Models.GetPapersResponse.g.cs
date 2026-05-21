
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPapersResponse
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
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseAuthor> Authors { get; set; }

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
        public global::HuggingFace.GetPapersResponseSubmittedOnDailyBy? SubmittedOnDailyBy { get; set; }

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
        /// only available when field contains 'submissionDeadline'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submissionDeadline")]
        public global::System.DateTime? SubmissionDeadline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedModels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedModel> LinkedModels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numTotalModels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumTotalModels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedDatasets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDataset> LinkedDatasets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numTotalDatasets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumTotalDatasets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedSpaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedSpace> LinkedSpaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numTotalSpaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumTotalSpaces { get; set; }

        /// <summary>
        /// only available when field contains 'comments'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseComment>? Comments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPapersResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="authors"></param>
        /// <param name="publishedAt"></param>
        /// <param name="title"></param>
        /// <param name="summary"></param>
        /// <param name="upvotes"></param>
        /// <param name="discussionId"></param>
        /// <param name="linkedModels"></param>
        /// <param name="numTotalModels"></param>
        /// <param name="linkedDatasets"></param>
        /// <param name="numTotalDatasets"></param>
        /// <param name="linkedSpaces"></param>
        /// <param name="numTotalSpaces"></param>
        /// <param name="mediaUrls"></param>
        /// <param name="submittedOnDailyAt"></param>
        /// <param name="submittedOnDailyBy">
        /// User overview information
        /// </param>
        /// <param name="withdrawnAt"></param>
        /// <param name="projectPage"></param>
        /// <param name="githubRepo"></param>
        /// <param name="aiSummary"></param>
        /// <param name="aiKeywords"></param>
        /// <param name="githubStars"></param>
        /// <param name="submissionDeadline">
        /// only available when field contains 'submissionDeadline'
        /// </param>
        /// <param name="comments">
        /// only available when field contains 'comments'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPapersResponse(
            string id,
            global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseAuthor> authors,
            global::System.DateTime publishedAt,
            string title,
            string summary,
            double upvotes,
            string discussionId,
            global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedModel> linkedModels,
            double numTotalModels,
            global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDataset> linkedDatasets,
            double numTotalDatasets,
            global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedSpace> linkedSpaces,
            double numTotalSpaces,
            global::System.Collections.Generic.IList<string>? mediaUrls,
            global::System.DateTime? submittedOnDailyAt,
            global::HuggingFace.GetPapersResponseSubmittedOnDailyBy? submittedOnDailyBy,
            global::System.DateTime? withdrawnAt,
            string? projectPage,
            string? githubRepo,
            string? aiSummary,
            global::System.Collections.Generic.IList<string>? aiKeywords,
            double? githubStars,
            global::System.DateTime? submissionDeadline,
            global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseComment>? comments)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Authors = authors ?? throw new global::System.ArgumentNullException(nameof(authors));
            this.MediaUrls = mediaUrls;
            this.PublishedAt = publishedAt;
            this.SubmittedOnDailyAt = submittedOnDailyAt;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.SubmittedOnDailyBy = submittedOnDailyBy;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Upvotes = upvotes;
            this.WithdrawnAt = withdrawnAt;
            this.DiscussionId = discussionId ?? throw new global::System.ArgumentNullException(nameof(discussionId));
            this.ProjectPage = projectPage;
            this.GithubRepo = githubRepo;
            this.AiSummary = aiSummary;
            this.AiKeywords = aiKeywords;
            this.GithubStars = githubStars;
            this.SubmissionDeadline = submissionDeadline;
            this.LinkedModels = linkedModels ?? throw new global::System.ArgumentNullException(nameof(linkedModels));
            this.NumTotalModels = numTotalModels;
            this.LinkedDatasets = linkedDatasets ?? throw new global::System.ArgumentNullException(nameof(linkedDatasets));
            this.NumTotalDatasets = numTotalDatasets;
            this.LinkedSpaces = linkedSpaces ?? throw new global::System.ArgumentNullException(nameof(linkedSpaces));
            this.NumTotalSpaces = numTotalSpaces;
            this.Comments = comments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPapersResponse" /> class.
        /// </summary>
        public GetPapersResponse()
        {
        }

    }
}