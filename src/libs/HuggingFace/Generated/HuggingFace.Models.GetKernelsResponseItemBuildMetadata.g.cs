
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Build metadata
    /// </summary>
    public sealed partial class GetKernelsResponseItemBuildMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compatibility")]
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibility? Compatibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backends")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackend> Backends { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKernelsResponseItemBuildMetadata" /> class.
        /// </summary>
        /// <param name="backends"></param>
        /// <param name="compatibility"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKernelsResponseItemBuildMetadata(
            global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackend> backends,
            global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibility? compatibility)
        {
            this.Compatibility = compatibility;
            this.Backends = backends ?? throw new global::System.ArgumentNullException(nameof(backends));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKernelsResponseItemBuildMetadata" /> class.
        /// </summary>
        public GetKernelsResponseItemBuildMetadata()
        {
        }

    }
}