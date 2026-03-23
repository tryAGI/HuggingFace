
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetsPreuploadRequestFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sample { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetsPreuploadRequestFile" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="size"></param>
        /// <param name="sample"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetsPreuploadRequestFile(
            string path,
            double size,
            string sample)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Size = size;
            this.Sample = sample ?? throw new global::System.ArgumentNullException(nameof(sample));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetsPreuploadRequestFile" /> class.
        /// </summary>
        public CreateDatasetsPreuploadRequestFile()
        {
        }
    }
}