
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetNotificationsResponseNotificationVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"post"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "post";

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
        [global::System.Text.Json.Serialization.JsonPropertyName("post")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetNotificationsResponseNotificationVariant3Post Post { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotificationsResponseNotificationVariant3" /> class.
        /// </summary>
        /// <param name="updatedAt"></param>
        /// <param name="read"></param>
        /// <param name="post"></param>
        /// <param name="discussionEventId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetNotificationsResponseNotificationVariant3(
            global::System.DateTime updatedAt,
            bool read,
            global::HuggingFace.GetNotificationsResponseNotificationVariant3Post post,
            string? discussionEventId,
            string type = "post")
        {
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.Read = read;
            this.DiscussionEventId = discussionEventId;
            this.Post = post ?? throw new global::System.ArgumentNullException(nameof(post));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotificationsResponseNotificationVariant3" /> class.
        /// </summary>
        public GetNotificationsResponseNotificationVariant3()
        {
        }
    }
}