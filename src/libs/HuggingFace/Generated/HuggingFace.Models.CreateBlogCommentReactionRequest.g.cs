
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateBlogCommentReactionRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reaction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateBlogCommentReactionRequestReactionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateBlogCommentReactionRequestReaction Reaction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateBlogCommentReactionRequestActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateBlogCommentReactionRequestAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBlogCommentReactionRequest" /> class.
        /// </summary>
        /// <param name="reaction"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBlogCommentReactionRequest(
            global::HuggingFace.CreateBlogCommentReactionRequestReaction reaction,
            global::HuggingFace.CreateBlogCommentReactionRequestAction action)
        {
            this.Reaction = reaction;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBlogCommentReactionRequest" /> class.
        /// </summary>
        public CreateBlogCommentReactionRequest()
        {
        }

    }
}