
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimilarityRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.SimilarityInput Inputs { get; set; }

        /// <summary>
        /// Default Value: null
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::HuggingFace.SimilarityParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityRequest" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="parameters">
        /// Default Value: null
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimilarityRequest(
            global::HuggingFace.SimilarityInput inputs,
            global::HuggingFace.SimilarityParameters? parameters)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityRequest" /> class.
        /// </summary>
        public SimilarityRequest()
        {
        }
    }
}