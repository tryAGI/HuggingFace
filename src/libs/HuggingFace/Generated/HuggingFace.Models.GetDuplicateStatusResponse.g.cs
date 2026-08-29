
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDuplicateStatusResponse
    {
        /// <summary>
        /// True while the LFS/Xet files are still being copied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pending { get; set; }

        /// <summary>
        /// Number of LFS/Xet files the duplicate references
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filesTotal")]
        public int? FilesTotal { get; set; }

        /// <summary>
        /// Number of files copied so far
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filesCopied")]
        public int? FilesCopied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDuplicateStatusResponse" /> class.
        /// </summary>
        /// <param name="pending">
        /// True while the LFS/Xet files are still being copied
        /// </param>
        /// <param name="filesTotal">
        /// Number of LFS/Xet files the duplicate references
        /// </param>
        /// <param name="filesCopied">
        /// Number of files copied so far
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDuplicateStatusResponse(
            bool pending,
            int? filesTotal,
            int? filesCopied)
        {
            this.Pending = pending;
            this.FilesTotal = filesTotal;
            this.FilesCopied = filesCopied;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDuplicateStatusResponse" /> class.
        /// </summary>
        public GetDuplicateStatusResponse()
        {
        }

    }
}