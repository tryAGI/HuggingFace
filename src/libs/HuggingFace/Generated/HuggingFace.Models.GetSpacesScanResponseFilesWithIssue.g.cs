
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSpacesScanResponseFilesWithIssue
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
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetSpacesScanResponseFilesWithIssueLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetSpacesScanResponseFilesWithIssueLevel Level { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesScanResponseFilesWithIssue" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="level"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSpacesScanResponseFilesWithIssue(
            string path,
            global::HuggingFace.GetSpacesScanResponseFilesWithIssueLevel level)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesScanResponseFilesWithIssue" /> class.
        /// </summary>
        public GetSpacesScanResponseFilesWithIssue()
        {
        }
    }
}