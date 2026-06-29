
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKernelsResponseItemBuildMetadataCompatibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("torch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem> Torch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("os")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO> Os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem> Arch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKernelsResponseItemBuildMetadataCompatibility" /> class.
        /// </summary>
        /// <param name="torch"></param>
        /// <param name="os"></param>
        /// <param name="arch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKernelsResponseItemBuildMetadataCompatibility(
            global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem> torch,
            global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO> os,
            global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem> arch)
        {
            this.Torch = torch ?? throw new global::System.ArgumentNullException(nameof(torch));
            this.Os = os ?? throw new global::System.ArgumentNullException(nameof(os));
            this.Arch = arch ?? throw new global::System.ArgumentNullException(nameof(arch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKernelsResponseItemBuildMetadataCompatibility" /> class.
        /// </summary>
        public GetKernelsResponseItemBuildMetadataCompatibility()
        {
        }

    }
}