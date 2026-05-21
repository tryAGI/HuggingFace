
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateKernelsLfsFilesDuplicateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTarget Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestFile> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKernelsLfsFilesDuplicateRequest" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKernelsLfsFilesDuplicateRequest(
            global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTarget target,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestFile> files)
        {
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKernelsLfsFilesDuplicateRequest" /> class.
        /// </summary>
        public CreateKernelsLfsFilesDuplicateRequest()
        {
        }

    }
}