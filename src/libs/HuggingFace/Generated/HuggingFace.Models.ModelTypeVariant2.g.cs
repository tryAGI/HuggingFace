
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelTypeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.EmbeddingModel Embedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTypeVariant2" /> class.
        /// </summary>
        /// <param name="embedding"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelTypeVariant2(
            global::HuggingFace.EmbeddingModel embedding)
        {
            this.Embedding = embedding ?? throw new global::System.ArgumentNullException(nameof(embedding));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTypeVariant2" /> class.
        /// </summary>
        public ModelTypeVariant2()
        {
        }
    }
}