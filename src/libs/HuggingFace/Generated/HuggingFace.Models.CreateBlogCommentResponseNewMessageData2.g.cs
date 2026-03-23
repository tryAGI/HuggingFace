
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBlogCommentResponseNewMessageData2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Edited { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Hidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hiddenBy")]
        public string? HiddenBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hiddenReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateBlogCommentResponseNewMessageDataHiddenReason2JsonConverter))]
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataHiddenReason2? HiddenReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatest2 Latest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numEdits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumEdits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Editors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editorAvatarUrls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EditorAvatarUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction2> Reactions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifiedLanguage")]
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataIdentifiedLanguage2? IdentifiedLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relatedEventId")]
        public string? RelatedEventId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isReport")]
        public bool? IsReport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentCommentId")]
        public string? ParentCommentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBlogCommentResponseNewMessageData2" /> class.
        /// </summary>
        /// <param name="edited"></param>
        /// <param name="hidden"></param>
        /// <param name="hiddenBy"></param>
        /// <param name="hiddenReason"></param>
        /// <param name="latest"></param>
        /// <param name="numEdits"></param>
        /// <param name="editors"></param>
        /// <param name="editorAvatarUrls"></param>
        /// <param name="reactions"></param>
        /// <param name="identifiedLanguage"></param>
        /// <param name="relatedEventId"></param>
        /// <param name="isReport"></param>
        /// <param name="parentCommentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBlogCommentResponseNewMessageData2(
            bool edited,
            bool hidden,
            global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatest2 latest,
            double numEdits,
            global::System.Collections.Generic.IList<string> editors,
            global::System.Collections.Generic.IList<string> editorAvatarUrls,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction2> reactions,
            string? hiddenBy,
            global::HuggingFace.CreateBlogCommentResponseNewMessageDataHiddenReason2? hiddenReason,
            global::HuggingFace.CreateBlogCommentResponseNewMessageDataIdentifiedLanguage2? identifiedLanguage,
            string? relatedEventId,
            bool? isReport,
            string? parentCommentId)
        {
            this.Edited = edited;
            this.Hidden = hidden;
            this.Latest = latest ?? throw new global::System.ArgumentNullException(nameof(latest));
            this.NumEdits = numEdits;
            this.Editors = editors ?? throw new global::System.ArgumentNullException(nameof(editors));
            this.EditorAvatarUrls = editorAvatarUrls ?? throw new global::System.ArgumentNullException(nameof(editorAvatarUrls));
            this.Reactions = reactions ?? throw new global::System.ArgumentNullException(nameof(reactions));
            this.HiddenBy = hiddenBy;
            this.HiddenReason = hiddenReason;
            this.IdentifiedLanguage = identifiedLanguage;
            this.RelatedEventId = relatedEventId;
            this.IsReport = isReport;
            this.ParentCommentId = parentCommentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBlogCommentResponseNewMessageData2" /> class.
        /// </summary>
        public CreateBlogCommentResponseNewMessageData2()
        {
        }
    }
}