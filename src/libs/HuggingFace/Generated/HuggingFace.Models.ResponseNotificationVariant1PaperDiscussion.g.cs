
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseNotificationVariant1PaperDiscussion
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
        [global::System.Text.Json.Serialization.JsonPropertyName("participating")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseNotificationVariant1PaperDiscussionParticipatingItem> Participating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paperId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PaperId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNotificationVariant1PaperDiscussion" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="participating"></param>
        /// <param name="paperId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseNotificationVariant1PaperDiscussion(
            string id,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseNotificationVariant1PaperDiscussionParticipatingItem> participating,
            string paperId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Participating = participating ?? throw new global::System.ArgumentNullException(nameof(participating));
            this.PaperId = paperId ?? throw new global::System.ArgumentNullException(nameof(paperId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNotificationVariant1PaperDiscussion" /> class.
        /// </summary>
        public ResponseNotificationVariant1PaperDiscussion()
        {
        }
    }
}