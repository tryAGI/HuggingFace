
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamDetails
    {
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
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputLength { get; set; }

        /// <summary>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamDetails" /> class.
        /// </summary>
        /// <param name="finishReason">
        /// Example: Length
        /// </param>
        /// <param name="generatedTokens">
        /// Example: 1
        /// </param>
        /// <param name="inputLength">
        /// Example: 1
        /// </param>
        /// <param name="seed">
        /// Example: 42
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamDetails(
            global::HuggingFace.FinishReason finishReason,
            int generatedTokens,
            int inputLength,
            long? seed)
        {
            this.FinishReason = finishReason;
            this.GeneratedTokens = generatedTokens;
            this.InputLength = inputLength;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamDetails" /> class.
        /// </summary>
        public StreamDetails()
        {
        }
    }
}