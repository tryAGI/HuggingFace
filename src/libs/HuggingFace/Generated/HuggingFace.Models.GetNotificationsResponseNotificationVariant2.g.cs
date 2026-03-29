
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetNotificationsResponseNotificationVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"repo"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "repo";

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
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.RepoId Repo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetNotificationsResponseNotificationVariant2Discussion Discussion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotificationsResponseNotificationVariant2" /> class.
        /// </summary>
        /// <param name="updatedAt"></param>
        /// <param name="read"></param>
        /// <param name="repo"></param>
        /// <param name="discussion"></param>
        /// <param name="discussionEventId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetNotificationsResponseNotificationVariant2(
            global::System.DateTime updatedAt,
            bool read,
            global::HuggingFace.RepoId repo,
            global::HuggingFace.GetNotificationsResponseNotificationVariant2Discussion discussion,
            string? discussionEventId,
            string type = "repo")
        {
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.Read = read;
            this.DiscussionEventId = discussionEventId;
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Discussion = discussion ?? throw new global::System.ArgumentNullException(nameof(discussion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotificationsResponseNotificationVariant2" /> class.
        /// </summary>
        public GetNotificationsResponseNotificationVariant2()
        {
        }
    }
}