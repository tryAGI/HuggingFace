
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDiscussionsCommentReactionRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reaction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateDiscussionsCommentReactionRequestReactionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateDiscussionsCommentReactionRequestReaction Reaction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateDiscussionsCommentReactionRequestActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateDiscussionsCommentReactionRequestAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsCommentReactionRequest" /> class.
        /// </summary>
        /// <param name="reaction"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDiscussionsCommentReactionRequest(
            global::HuggingFace.CreateDiscussionsCommentReactionRequestReaction reaction,
            global::HuggingFace.CreateDiscussionsCommentReactionRequestAction action)
        {
            this.Reaction = reaction;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsCommentReactionRequest" /> class.
        /// </summary>
        public CreateDiscussionsCommentReactionRequest()
        {
        }

    }
}