
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseNotificationVariant2Discussion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Num { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseNotificationVariant2DiscussionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseNotificationVariant2DiscussionStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPullRequest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPullRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("participating")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseNotificationVariant2DiscussionParticipatingItem> Participating { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNotificationVariant2Discussion" /> class.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="title"></param>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <param name="isPullRequest"></param>
        /// <param name="participating"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseNotificationVariant2Discussion(
            double num,
            string title,
            global::HuggingFace.ResponseNotificationVariant2DiscussionStatus status,
            string id,
            bool isPullRequest,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseNotificationVariant2DiscussionParticipatingItem> participating)
        {
            this.Num = num;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Status = status;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsPullRequest = isPullRequest;
            this.Participating = participating ?? throw new global::System.ArgumentNullException(nameof(participating));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNotificationVariant2Discussion" /> class.
        /// </summary>
        public ResponseNotificationVariant2Discussion()
        {
        }
    }
}