
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response102
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scansDone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ScansDone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filesWithIssues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseFilesWithIssue2> FilesWithIssues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response102" /> class.
        /// </summary>
        /// <param name="scansDone"></param>
        /// <param name="filesWithIssues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response102(
            bool scansDone,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseFilesWithIssue2> filesWithIssues)
        {
            this.ScansDone = scansDone;
            this.FilesWithIssues = filesWithIssues ?? throw new global::System.ArgumentNullException(nameof(filesWithIssues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response102" /> class.
        /// </summary>
        public Response102()
        {
        }
    }
}