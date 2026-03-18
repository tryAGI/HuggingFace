
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAICompatEmbedding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.EmbeddingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.Embedding Embedding { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Example: embedding
        /// </summary>
        /// <example>embedding</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAICompatEmbedding" /> class.
        /// </summary>
        /// <param name="embedding"></param>
        /// <param name="index">
        /// Example: 0
        /// </param>
        /// <param name="object">
        /// Example: embedding
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAICompatEmbedding(
            global::HuggingFace.Embedding embedding,
            int index,
            string @object)
        {
            this.Embedding = embedding;
            this.Index = index;
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAICompatEmbedding" /> class.
        /// </summary>
        public OpenAICompatEmbedding()
        {
        }
    }
}