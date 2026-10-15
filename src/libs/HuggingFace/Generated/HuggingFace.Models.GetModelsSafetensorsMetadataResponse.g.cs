
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetModelsSafetensorsMetadataResponse
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharded")]
        public bool Sharded { get; set; } = true;

        /// <summary>
        /// The index file, without its `weight_map`: each shard header lists its tensors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetModelsSafetensorsMetadataResponseIndex Index { get; set; }

        /// <summary>
        /// The header of each shard, by shard file name: `__metadata__`, then the `dtype`, `shape` and `data_offsets` of each tensor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object> Headers { get; set; }

        /// <summary>
        /// Number of parameters per dtype
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameterCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> ParameterCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameterTotal")]
        public int? ParameterTotal { get; set; }

        /// <summary>
        /// The index file, then every shard file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filepaths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Filepaths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsSafetensorsMetadataResponse" /> class.
        /// </summary>
        /// <param name="index">
        /// The index file, without its `weight_map`: each shard header lists its tensors
        /// </param>
        /// <param name="headers">
        /// The header of each shard, by shard file name: `__metadata__`, then the `dtype`, `shape` and `data_offsets` of each tensor
        /// </param>
        /// <param name="parameterCount">
        /// Number of parameters per dtype
        /// </param>
        /// <param name="filepaths">
        /// The index file, then every shard file
        /// </param>
        /// <param name="parameterTotal"></param>
        /// <param name="sharded"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsSafetensorsMetadataResponse(
            global::HuggingFace.GetModelsSafetensorsMetadataResponseIndex index,
            global::System.Collections.Generic.Dictionary<string, object> headers,
            global::System.Collections.Generic.Dictionary<string, int> parameterCount,
            global::System.Collections.Generic.IList<string> filepaths,
            int? parameterTotal,
            bool sharded = true)
        {
            this.Sharded = sharded;
            this.Index = index ?? throw new global::System.ArgumentNullException(nameof(index));
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.ParameterCount = parameterCount ?? throw new global::System.ArgumentNullException(nameof(parameterCount));
            this.ParameterTotal = parameterTotal;
            this.Filepaths = filepaths ?? throw new global::System.ArgumentNullException(nameof(filepaths));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsSafetensorsMetadataResponse" /> class.
        /// </summary>
        public GetModelsSafetensorsMetadataResponse()
        {
        }

    }
}