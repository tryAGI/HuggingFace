
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateBlogCommentReactionRequest2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reaction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateBlogCommentReactionRequestReaction2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateBlogCommentReactionRequestReaction2 Reaction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateBlogCommentReactionRequestAction2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateBlogCommentReactionRequestAction2 Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBlogCommentReactionRequest2" /> class.
        /// </summary>
        /// <param name="reaction"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBlogCommentReactionRequest2(
            global::HuggingFace.CreateBlogCommentReactionRequestReaction2 reaction,
            global::HuggingFace.CreateBlogCommentReactionRequestAction2 action)
        {
            this.Reaction = reaction;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBlogCommentReactionRequest2" /> class.
        /// </summary>
        public CreateBlogCommentReactionRequest2()
        {
        }

    }
}