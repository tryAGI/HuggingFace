
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamResponse
    {
        /// <summary>
        /// Default Value: null
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::HuggingFace.StreamDetails? Details { get; set; }

        /// <summary>
        /// Default Value: null<br/>
        /// Example: test
        /// </summary>
        /// <example>test</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_text")]
        public string? GeneratedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.Token Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_tokens")]
        public global::System.Collections.Generic.IList<global::HuggingFace.Token>? TopTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamResponse" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="token"></param>
        /// <param name="details">
        /// Default Value: null
        /// </param>
        /// <param name="generatedText">
        /// Default Value: null<br/>
        /// Example: test
        /// </param>
        /// <param name="topTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamResponse(
            int index,
            global::HuggingFace.Token token,
            global::HuggingFace.StreamDetails? details,
            string? generatedText,
            global::System.Collections.Generic.IList<global::HuggingFace.Token>? topTokens)
        {
            this.Details = details;
            this.GeneratedText = generatedText;
            this.Index = index;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.TopTokens = topTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamResponse" /> class.
        /// </summary>
        public StreamResponse()
        {
        }
    }
}