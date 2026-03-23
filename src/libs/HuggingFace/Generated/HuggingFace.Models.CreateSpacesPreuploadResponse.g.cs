
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpacesPreuploadResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPreuploadResponseFile> Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitOid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitOid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpacesPreuploadResponse" /> class.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="commitOid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpacesPreuploadResponse(
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPreuploadResponseFile> files,
            string commitOid)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.CommitOid = commitOid ?? throw new global::System.ArgumentNullException(nameof(commitOid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpacesPreuploadResponse" /> class.
        /// </summary>
        public CreateSpacesPreuploadResponse()
        {
        }
    }
}