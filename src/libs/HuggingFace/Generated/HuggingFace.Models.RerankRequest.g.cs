
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankRequest
    {
        /// <summary>
        /// Example: What is Deep Learning?
        /// </summary>
        /// <example>What is Deep Learning?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("return_text")]
        public bool? ReturnText { get; set; }

        /// <summary>
        /// Example: [Deep Learning is ...]
        /// </summary>
        /// <example>[Deep Learning is ...]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Texts { get; set; }

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
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Example: What is Deep Learning?
        /// </param>
        /// <param name="rawScores">
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="returnText">
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="texts">
        /// Example: [Deep Learning is ...]
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
        public RerankRequest(
            string query,
            global::System.Collections.Generic.IList<string> texts,
            bool? rawScores,
            bool? returnText,
            bool? truncate,
            global::HuggingFace.TruncationDirection? truncationDirection)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Texts = texts ?? throw new global::System.ArgumentNullException(nameof(texts));
            this.RawScores = rawScores;
            this.ReturnText = returnText;
            this.Truncate = truncate;
            this.TruncationDirection = truncationDirection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        public RerankRequest()
        {
        }
    }
}