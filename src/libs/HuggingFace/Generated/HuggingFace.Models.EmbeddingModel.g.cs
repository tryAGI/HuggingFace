
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingModel
    {
        /// <summary>
        /// Example: cls
        /// </summary>
        /// <example>cls</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pooling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pooling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingModel" /> class.
        /// </summary>
        /// <param name="pooling">
        /// Example: cls
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingModel(
            string pooling)
        {
            this.Pooling = pooling ?? throw new global::System.ArgumentNullException(nameof(pooling));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingModel" /> class.
        /// </summary>
        public EmbeddingModel()
        {
        }
    }
}