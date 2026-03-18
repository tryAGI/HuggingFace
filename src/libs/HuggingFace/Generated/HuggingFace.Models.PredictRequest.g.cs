
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictRequest
    {
        /// <summary>
        /// Model input. Can be either a single string, a pair of strings or a batch of mixed single and pairs of strings.<br/>
        /// Example: What is Deep Learning?
        /// </summary>
        /// <example>What is Deep Learning?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PredictInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PredictInput Inputs { get; set; }

        /// <summary>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_scores")]
        public bool? RawScores { get; set; }

        /// <summary>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        public bool? Truncate { get; set; }

        /// <summary>
        /// Default Value: right
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation_direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.TruncationDirectionJsonConverter))]
        public global::HuggingFace.TruncationDirection? TruncationDirection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Model input. Can be either a single string, a pair of strings or a batch of mixed single and pairs of strings.<br/>
        /// Example: What is Deep Learning?
        /// </param>
        /// <param name="rawScores">
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="truncate">
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="truncationDirection">
        /// Default Value: right
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictRequest(
            global::HuggingFace.PredictInput inputs,
            bool? rawScores,
            bool? truncate,
            global::HuggingFace.TruncationDirection? truncationDirection)
        {
            this.Inputs = inputs;
            this.RawScores = rawScores;
            this.Truncate = truncate;
            this.TruncationDirection = truncationDirection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictRequest" /> class.
        /// </summary>
        public PredictRequest()
        {
        }
    }
}