
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimilarityInput
    {
        /// <summary>
        /// A list of strings which will be compared against the source_sentence.<br/>
        /// Example: [What is Machine Learning?]
        /// </summary>
        /// <example>[What is Machine Learning?]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Sentences { get; set; }

        /// <summary>
        /// The string that you wish to compare the other strings with. This can be a phrase, sentence,<br/>
        /// or longer passage, depending on the model being used.<br/>
        /// Example: What is Deep Learning?
        /// </summary>
        /// <example>What is Deep Learning?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_sentence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceSentence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityInput" /> class.
        /// </summary>
        /// <param name="sentences">
        /// A list of strings which will be compared against the source_sentence.<br/>
        /// Example: [What is Machine Learning?]
        /// </param>
        /// <param name="sourceSentence">
        /// The string that you wish to compare the other strings with. This can be a phrase, sentence,<br/>
        /// or longer passage, depending on the model being used.<br/>
        /// Example: What is Deep Learning?
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimilarityInput(
            global::System.Collections.Generic.IList<string> sentences,
            string sourceSentence)
        {
            this.Sentences = sentences ?? throw new global::System.ArgumentNullException(nameof(sentences));
            this.SourceSentence = sourceSentence ?? throw new global::System.ArgumentNullException(nameof(sourceSentence));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityInput" /> class.
        /// </summary>
        public SimilarityInput()
        {
        }
    }
}