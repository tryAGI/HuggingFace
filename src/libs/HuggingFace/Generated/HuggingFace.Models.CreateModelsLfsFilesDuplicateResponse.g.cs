
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelsLfsFilesDuplicateResponse
    {
        /// <summary>
        /// True if all requested files were duplicated (or already present)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Total number of unique files processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Processed { get; set; }

        /// <summary>
        /// Number of files duplicated or already present in the target
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Succeeded { get; set; }

        /// <summary>
        /// Per-file failures
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem> Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsLfsFilesDuplicateResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// True if all requested files were duplicated (or already present)
        /// </param>
        /// <param name="processed">
        /// Total number of unique files processed
        /// </param>
        /// <param name="succeeded">
        /// Number of files duplicated or already present in the target
        /// </param>
        /// <param name="failed">
        /// Per-file failures
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelsLfsFilesDuplicateResponse(
            bool success,
            int processed,
            int succeeded,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem> failed)
        {
            this.Success = success;
            this.Processed = processed;
            this.Succeeded = succeeded;
            this.Failed = failed ?? throw new global::System.ArgumentNullException(nameof(failed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsLfsFilesDuplicateResponse" /> class.
        /// </summary>
        public CreateModelsLfsFilesDuplicateResponse()
        {
        }

    }
}