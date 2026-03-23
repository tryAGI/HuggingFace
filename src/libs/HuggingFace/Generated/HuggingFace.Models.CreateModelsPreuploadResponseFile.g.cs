
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelsPreuploadResponseFile
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
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateModelsPreuploadResponseFileUploadModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateModelsPreuploadResponseFileUploadMode UploadMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldIgnore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ShouldIgnore { get; set; }

        /// <summary>
        /// The oid of the blob if it already exists in the repository. If the blob is a LFS file, it'll be the lfs oid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oid")]
        public string? Oid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsPreuploadResponseFile" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="uploadMode"></param>
        /// <param name="shouldIgnore"></param>
        /// <param name="oid">
        /// The oid of the blob if it already exists in the repository. If the blob is a LFS file, it'll be the lfs oid.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelsPreuploadResponseFile(
            string path,
            global::HuggingFace.CreateModelsPreuploadResponseFileUploadMode uploadMode,
            bool shouldIgnore,
            string? oid)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.UploadMode = uploadMode;
            this.ShouldIgnore = shouldIgnore;
            this.Oid = oid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsPreuploadResponseFile" /> class.
        /// </summary>
        public CreateModelsPreuploadResponseFile()
        {
        }
    }
}