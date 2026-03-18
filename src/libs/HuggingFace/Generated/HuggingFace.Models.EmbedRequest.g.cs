
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedRequest
    {
        /// <summary>
        /// The number of dimensions that the output embeddings should have. If not set, the original<br/>
        /// shape of the representation will be returned instead.<br/>
        /// Default Value: null<br/>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.InputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.Input Inputs { get; set; }

        /// <summary>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize")]
        public bool? Normalize { get; set; }

        /// <summary>
        /// The name of the prompt that should be used by for encoding. If not set, no prompt<br/>
        /// will be applied.<br/>
        /// Must be a key in the `sentence-transformers` configuration `prompts` dictionary.<br/>
        /// For example if ``prompt_name`` is "query" and the ``prompts`` is {"query": "query: ", ...},<br/>
        /// then the sentence "What is the capital of France?" will be encoded as<br/>
        /// "query: What is the capital of France?" because the prompt text will be prepended before<br/>
        /// any text to encode.<br/>
        /// Default Value: null<br/>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        public string? PromptName { get; set; }

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
        /// Initializes a new instance of the <see cref="EmbedRequest" /> class.
        /// </summary>
        /// <param name="dimensions">
        /// The number of dimensions that the output embeddings should have. If not set, the original<br/>
        /// shape of the representation will be returned instead.<br/>
        /// Default Value: null<br/>
        /// Example: null
        /// </param>
        /// <param name="inputs"></param>
        /// <param name="normalize">
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="promptName">
        /// The name of the prompt that should be used by for encoding. If not set, no prompt<br/>
        /// will be applied.<br/>
        /// Must be a key in the `sentence-transformers` configuration `prompts` dictionary.<br/>
        /// For example if ``prompt_name`` is "query" and the ``prompts`` is {"query": "query: ", ...},<br/>
        /// then the sentence "What is the capital of France?" will be encoded as<br/>
        /// "query: What is the capital of France?" because the prompt text will be prepended before<br/>
        /// any text to encode.<br/>
        /// Default Value: null<br/>
        /// Example: null
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
        public EmbedRequest(
            global::HuggingFace.Input inputs,
            int? dimensions,
            bool? normalize,
            string? promptName,
            bool? truncate,
            global::HuggingFace.TruncationDirection? truncationDirection)
        {
            this.Inputs = inputs;
            this.Dimensions = dimensions;
            this.Normalize = normalize;
            this.PromptName = promptName;
            this.Truncate = truncate;
            this.TruncationDirection = truncationDirection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedRequest" /> class.
        /// </summary>
        public EmbedRequest()
        {
        }
    }
}