
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDiscussionsMarkAsReadRequest
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussionIds")]
        public global::System.Collections.Generic.IList<string>? DiscussionIds { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        public bool? Read { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsMarkAsReadRequest" /> class.
        /// </summary>
        /// <param name="discussionIds">
        /// Default Value: []
        /// </param>
        /// <param name="read">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDiscussionsMarkAsReadRequest(
            global::System.Collections.Generic.IList<string>? discussionIds,
            bool? read)
        {
            this.DiscussionIds = discussionIds;
            this.Read = read;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsMarkAsReadRequest" /> class.
        /// </summary>
        public CreateDiscussionsMarkAsReadRequest()
        {
        }
    }
}