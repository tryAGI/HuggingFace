
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelsLfsFilesDuplicateRequestFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xetHash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XetHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha256 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsLfsFilesDuplicateRequestFile" /> class.
        /// </summary>
        /// <param name="xetHash"></param>
        /// <param name="sha256"></param>
        /// <param name="filename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelsLfsFilesDuplicateRequestFile(
            string xetHash,
            string sha256,
            string? filename)
        {
            this.XetHash = xetHash ?? throw new global::System.ArgumentNullException(nameof(xetHash));
            this.Sha256 = sha256 ?? throw new global::System.ArgumentNullException(nameof(sha256));
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsLfsFilesDuplicateRequestFile" /> class.
        /// </summary>
        public CreateModelsLfsFilesDuplicateRequestFile()
        {
        }

    }
}