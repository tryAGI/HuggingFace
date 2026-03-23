
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePapersIndexRequest
    {
        /// <summary>
        /// The arXiv ID of the paper to index (e.g. 2301.00001)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arxivId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArxivId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePapersIndexRequest" /> class.
        /// </summary>
        /// <param name="arxivId">
        /// The arXiv ID of the paper to index (e.g. 2301.00001)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePapersIndexRequest(
            string arxivId)
        {
            this.ArxivId = arxivId ?? throw new global::System.ArgumentNullException(nameof(arxivId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePapersIndexRequest" /> class.
        /// </summary>
        public CreatePapersIndexRequest()
        {
        }
    }
}