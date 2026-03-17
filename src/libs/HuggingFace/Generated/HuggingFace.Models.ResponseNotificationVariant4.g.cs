
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseNotificationVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"community_blog"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "community_blog";

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
        [global::System.Text.Json.Serialization.JsonPropertyName("blog")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseNotificationVariant4Blog Blog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNotificationVariant4" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="updatedAt"></param>
        /// <param name="read"></param>
        /// <param name="discussionEventId"></param>
        /// <param name="blog"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseNotificationVariant4(
            global::System.DateTime updatedAt,
            bool read,
            global::HuggingFace.ResponseNotificationVariant4Blog blog,
            string? discussionEventId,
            string type = "community_blog")
        {
            this.UpdatedAt = updatedAt;
            this.Read = read;
            this.Blog = blog ?? throw new global::System.ArgumentNullException(nameof(blog));
            this.Type = type;
            this.DiscussionEventId = discussionEventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNotificationVariant4" /> class.
        /// </summary>
        public ResponseNotificationVariant4()
        {
        }
    }
}