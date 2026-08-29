
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDuplicateResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// True when the repo's LFS/Xet files are still being copied in the background; poll `…/duplicate/status`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filesCopyPending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FilesCopyPending { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDuplicateResponse" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="filesCopyPending">
        /// True when the repo's LFS/Xet files are still being copied in the background; poll `…/duplicate/status`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDuplicateResponse(
            string url,
            bool filesCopyPending)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.FilesCopyPending = filesCopyPending;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDuplicateResponse" /> class.
        /// </summary>
        public CreateDuplicateResponse()
        {
        }

    }
}