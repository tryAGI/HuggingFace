
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelsUserAccessRequestBatchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateModelsUserAccessRequestBatchRequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateModelsUserAccessRequestBatchRequestStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejectionReason")]
        public string? RejectionReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsUserAccessRequestBatchRequestRequest> Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsUserAccessRequestBatchRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="requests"></param>
        /// <param name="rejectionReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelsUserAccessRequestBatchRequest(
            global::HuggingFace.CreateModelsUserAccessRequestBatchRequestStatus status,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsUserAccessRequestBatchRequestRequest> requests,
            string? rejectionReason)
        {
            this.Status = status;
            this.RejectionReason = rejectionReason;
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsUserAccessRequestBatchRequest" /> class.
        /// </summary>
        public CreateModelsUserAccessRequestBatchRequest()
        {
        }
    }
}