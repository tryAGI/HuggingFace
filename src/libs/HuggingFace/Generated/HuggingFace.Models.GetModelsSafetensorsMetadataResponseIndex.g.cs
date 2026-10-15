
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// The index file, without its `weight_map`: each shard header lists its tensors
    /// </summary>
    public sealed partial class GetModelsSafetensorsMetadataResponseIndex
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsSafetensorsMetadataResponseIndex" /> class.
        /// </summary>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsSafetensorsMetadataResponseIndex(
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsSafetensorsMetadataResponseIndex" /> class.
        /// </summary>
        public GetModelsSafetensorsMetadataResponseIndex()
        {
        }

    }
}