
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Details
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("best_of_sequences")]
        public global::System.Collections.Generic.IList<global::HuggingFace.BestOfSequence>? BestOfSequences { get; set; }

        /// <summary>
        /// Example: Length
        /// </summary>
        /// <example>Length</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.FinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.FinishReason FinishReason { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GeneratedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefill")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.PrefillToken> Prefill { get; set; }

        /// <summary>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.Token> Tokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_tokens")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.Token>>? TopTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Details" /> class.
        /// </summary>
        /// <param name="bestOfSequences"></param>
        /// <param name="finishReason">
        /// Example: Length
        /// </param>
        /// <param name="generatedTokens">
        /// Example: 1
        /// </param>
        /// <param name="prefill"></param>
        /// <param name="seed">
        /// Example: 42
        /// </param>
        /// <param name="tokens"></param>
        /// <param name="topTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Details(
            global::HuggingFace.FinishReason finishReason,
            int generatedTokens,
            global::System.Collections.Generic.IList<global::HuggingFace.PrefillToken> prefill,
            global::System.Collections.Generic.IList<global::HuggingFace.Token> tokens,
            global::System.Collections.Generic.IList<global::HuggingFace.BestOfSequence>? bestOfSequences,
            long? seed,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.Token>>? topTokens)
        {
            this.FinishReason = finishReason;
            this.GeneratedTokens = generatedTokens;
            this.Prefill = prefill ?? throw new global::System.ArgumentNullException(nameof(prefill));
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
            this.BestOfSequences = bestOfSequences;
            this.Seed = seed;
            this.TopTokens = topTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details" /> class.
        /// </summary>
        public Details()
        {
        }
    }
}