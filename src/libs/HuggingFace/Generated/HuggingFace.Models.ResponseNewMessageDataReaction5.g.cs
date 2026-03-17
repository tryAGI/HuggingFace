
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseNewMessageDataReaction5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reaction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseNewMessageDataReactionReaction5JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseNewMessageDataReactionReaction5 Reaction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNewMessageDataReaction5" /> class.
        /// </summary>
        /// <param name="reaction"></param>
        /// <param name="users"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseNewMessageDataReaction5(
            global::HuggingFace.ResponseNewMessageDataReactionReaction5 reaction,
            global::System.Collections.Generic.IList<string> users,
            double count)
        {
            this.Reaction = reaction;
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNewMessageDataReaction5" /> class.
        /// </summary>
        public ResponseNewMessageDataReaction5()
        {
        }
    }
}