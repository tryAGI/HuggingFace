
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseNotificationVariant1PaperDiscussionParticipatingItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNotificationVariant1PaperDiscussionParticipatingItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="avatar"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseNotificationVariant1PaperDiscussionParticipatingItem(
            string id,
            string avatar,
            string user)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Avatar = avatar ?? throw new global::System.ArgumentNullException(nameof(avatar));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNotificationVariant1PaperDiscussionParticipatingItem" /> class.
        /// </summary>
        public ResponseNotificationVariant1PaperDiscussionParticipatingItem()
        {
        }
    }
}