
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request33
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.RequestFile> Files { get; set; }

        /// <summary>
        /// Provide this parameter if you plan to modify `.gitattributes` yourself at the same time as uploading LFS files. Note that this is not needed if you solely rely on automatic LFS detection from HF: the commit endpoint will automatically edit the `.gitattributes` file to track the files passed to its `lfsFiles` param.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitAttributes")]
        public string? GitAttributes { get; set; }

        /// <summary>
        /// Content of the .gitignore file for the revision. Optional, otherwise takes the existing content of `.gitignore` for the revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitIgnore")]
        public string? GitIgnore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request33" /> class.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="gitAttributes">
        /// Provide this parameter if you plan to modify `.gitattributes` yourself at the same time as uploading LFS files. Note that this is not needed if you solely rely on automatic LFS detection from HF: the commit endpoint will automatically edit the `.gitattributes` file to track the files passed to its `lfsFiles` param.
        /// </param>
        /// <param name="gitIgnore">
        /// Content of the .gitignore file for the revision. Optional, otherwise takes the existing content of `.gitignore` for the revision.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request33(
            global::System.Collections.Generic.IList<global::HuggingFace.RequestFile> files,
            string? gitAttributes,
            string? gitIgnore)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.GitAttributes = gitAttributes;
            this.GitIgnore = gitIgnore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request33" /> class.
        /// </summary>
        public Request33()
        {
        }
    }
}