
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatTokenizeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templated_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplatedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenize_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.SimpleToken> TokenizeResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTokenizeResponse" /> class.
        /// </summary>
        /// <param name="templatedText"></param>
        /// <param name="tokenizeResponse"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatTokenizeResponse(
            string templatedText,
            global::System.Collections.Generic.IList<global::HuggingFace.SimpleToken> tokenizeResponse)
        {
            this.TemplatedText = templatedText ?? throw new global::System.ArgumentNullException(nameof(templatedText));
            this.TokenizeResponse = tokenizeResponse ?? throw new global::System.ArgumentNullException(nameof(tokenizeResponse));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTokenizeResponse" /> class.
        /// </summary>
        public ChatTokenizeResponse()
        {
        }
    }
}