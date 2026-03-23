
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteNotificationsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussionIds")]
        public global::System.Collections.Generic.IList<string>? DiscussionIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteNotificationsRequest" /> class.
        /// </summary>
        /// <param name="discussionIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteNotificationsRequest(
            global::System.Collections.Generic.IList<string>? discussionIds)
        {
            this.DiscussionIds = discussionIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteNotificationsRequest" /> class.
        /// </summary>
        public DeleteNotificationsRequest()
        {
        }
    }
}