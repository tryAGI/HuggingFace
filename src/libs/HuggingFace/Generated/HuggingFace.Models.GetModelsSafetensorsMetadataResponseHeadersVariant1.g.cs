
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetModelsSafetensorsMetadataResponseHeadersVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtype")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dtype { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shape")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Shape { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_offsets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> DataOffsets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsSafetensorsMetadataResponseHeadersVariant1" /> class.
        /// </summary>
        /// <param name="dtype"></param>
        /// <param name="shape"></param>
        /// <param name="dataOffsets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsSafetensorsMetadataResponseHeadersVariant1(
            string dtype,
            global::System.Collections.Generic.IList<int> shape,
            global::System.Collections.Generic.IList<int> dataOffsets)
        {
            this.Dtype = dtype ?? throw new global::System.ArgumentNullException(nameof(dtype));
            this.Shape = shape ?? throw new global::System.ArgumentNullException(nameof(shape));
            this.DataOffsets = dataOffsets ?? throw new global::System.ArgumentNullException(nameof(dataOffsets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsSafetensorsMetadataResponseHeadersVariant1" /> class.
        /// </summary>
        public GetModelsSafetensorsMetadataResponseHeadersVariant1()
        {
        }

    }
}