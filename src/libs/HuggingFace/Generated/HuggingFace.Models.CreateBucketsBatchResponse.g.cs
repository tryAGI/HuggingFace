
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBucketsBatchResponse
    {
        /// <summary>
        /// True if all operations succeeded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Total number of operations attempted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Processed { get; set; }

        /// <summary>
        /// Number of successful operations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Succeeded { get; set; }

        /// <summary>
        /// List of failed operations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsBatchResponseFailedItem> Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBucketsBatchResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// True if all operations succeeded
        /// </param>
        /// <param name="processed">
        /// Total number of operations attempted
        /// </param>
        /// <param name="succeeded">
        /// Number of successful operations
        /// </param>
        /// <param name="failed">
        /// List of failed operations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBucketsBatchResponse(
            bool success,
            int processed,
            int succeeded,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsBatchResponseFailedItem> failed)
        {
            this.Success = success;
            this.Processed = processed;
            this.Succeeded = succeeded;
            this.Failed = failed ?? throw new global::System.ArgumentNullException(nameof(failed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBucketsBatchResponse" /> class.
        /// </summary>
        public CreateBucketsBatchResponse()
        {
        }
    }
}