
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDocsSearchResponseItemVectors
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Embeddings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocsSearchResponseItemVectors" /> class.
        /// </summary>
        /// <param name="embeddings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDocsSearchResponseItemVectors(
            global::System.Collections.Generic.IList<double> embeddings)
        {
            this.Embeddings = embeddings ?? throw new global::System.ArgumentNullException(nameof(embeddings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocsSearchResponseItemVectors" /> class.
        /// </summary>
        public GetDocsSearchResponseItemVectors()
        {
        }
    }
}