
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Daily paper data for API responses
    /// </summary>
    public sealed partial class GetDailyPapersResponseItem
    {
        /// <summary>
        /// Paper data with metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paper")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDailyPapersResponseItemPaper Paper { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaUrls")]
        public global::System.Collections.Generic.IList<string>? MediaUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Thumbnail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numComments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumComments { get; set; }

        /// <summary>
        /// User overview information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDailyPapersResponseItemSubmittedBy SubmittedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAuthorParticipating")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAuthorParticipating { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDailyPapersResponseItem" /> class.
        /// </summary>
        /// <param name="paper">
        /// Paper data with metadata
        /// </param>
        /// <param name="publishedAt"></param>
        /// <param name="title"></param>
        /// <param name="summary"></param>
        /// <param name="mediaUrls"></param>
        /// <param name="thumbnail"></param>
        /// <param name="numComments"></param>
        /// <param name="submittedBy">
        /// User overview information
        /// </param>
        /// <param name="isAuthorParticipating"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDailyPapersResponseItem(
            global::HuggingFace.GetDailyPapersResponseItemPaper paper,
            global::System.DateTime publishedAt,
            string title,
            string summary,
            string thumbnail,
            double numComments,
            global::HuggingFace.GetDailyPapersResponseItemSubmittedBy submittedBy,
            bool isAuthorParticipating,
            global::System.Collections.Generic.IList<string>? mediaUrls)
        {
            this.Paper = paper ?? throw new global::System.ArgumentNullException(nameof(paper));
            this.PublishedAt = publishedAt;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Thumbnail = thumbnail ?? throw new global::System.ArgumentNullException(nameof(thumbnail));
            this.NumComments = numComments;
            this.SubmittedBy = submittedBy ?? throw new global::System.ArgumentNullException(nameof(submittedBy));
            this.IsAuthorParticipating = isAuthorParticipating;
            this.MediaUrls = mediaUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDailyPapersResponseItem" /> class.
        /// </summary>
        public GetDailyPapersResponseItem()
        {
        }
    }
}