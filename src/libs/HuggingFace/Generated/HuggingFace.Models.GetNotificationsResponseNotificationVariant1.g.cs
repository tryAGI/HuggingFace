
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetNotificationsResponseNotificationVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"paper"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "paper";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Read { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussionEventId")]
        public string? DiscussionEventId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paper")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetNotificationsResponseNotificationVariant1Paper Paper { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paperDiscussion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussion PaperDiscussion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotificationsResponseNotificationVariant1" /> class.
        /// </summary>
        /// <param name="updatedAt"></param>
        /// <param name="read"></param>
        /// <param name="paper"></param>
        /// <param name="paperDiscussion"></param>
        /// <param name="discussionEventId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetNotificationsResponseNotificationVariant1(
            global::System.DateTime updatedAt,
            bool read,
            global::HuggingFace.GetNotificationsResponseNotificationVariant1Paper paper,
            global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussion paperDiscussion,
            string? discussionEventId,
            string type = "paper")
        {
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.Read = read;
            this.DiscussionEventId = discussionEventId;
            this.Paper = paper ?? throw new global::System.ArgumentNullException(nameof(paper));
            this.PaperDiscussion = paperDiscussion ?? throw new global::System.ArgumentNullException(nameof(paperDiscussion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotificationsResponseNotificationVariant1" /> class.
        /// </summary>
        public GetNotificationsResponseNotificationVariant1()
        {
        }
    }
}