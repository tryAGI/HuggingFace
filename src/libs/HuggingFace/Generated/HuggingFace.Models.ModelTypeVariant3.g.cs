
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelTypeVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reranker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ClassifierModel Reranker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTypeVariant3" /> class.
        /// </summary>
        /// <param name="reranker"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelTypeVariant3(
            global::HuggingFace.ClassifierModel reranker)
        {
            this.Reranker = reranker ?? throw new global::System.ArgumentNullException(nameof(reranker));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTypeVariant3" /> class.
        /// </summary>
        public ModelTypeVariant3()
        {
        }
    }
}