
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKernelsResponseItemBuildMetadataBackend
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetKernelsResponseItemBuildMetadataBackendTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardwareTypes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType> HardwareTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noArchs")]
        public string? NoArchs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKernelsResponseItemBuildMetadataBackend" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="hardwareTypes"></param>
        /// <param name="noArchs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKernelsResponseItemBuildMetadataBackend(
            global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendType type,
            global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType> hardwareTypes,
            string? noArchs)
        {
            this.Type = type;
            this.HardwareTypes = hardwareTypes ?? throw new global::System.ArgumentNullException(nameof(hardwareTypes));
            this.NoArchs = noArchs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKernelsResponseItemBuildMetadataBackend" /> class.
        /// </summary>
        public GetKernelsResponseItemBuildMetadataBackend()
        {
        }

    }
}