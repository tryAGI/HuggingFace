
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePostsCommentReactionRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reaction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreatePostsCommentReactionRequestReactionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreatePostsCommentReactionRequestReaction Reaction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreatePostsCommentReactionRequestActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreatePostsCommentReactionRequestAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePostsCommentReactionRequest" /> class.
        /// </summary>
        /// <param name="reaction"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePostsCommentReactionRequest(
            global::HuggingFace.CreatePostsCommentReactionRequestReaction reaction,
            global::HuggingFace.CreatePostsCommentReactionRequestAction action)
        {
            this.Reaction = reaction;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePostsCommentReactionRequest" /> class.
        /// </summary>
        public CreatePostsCommentReactionRequest()
        {
        }

    }
}