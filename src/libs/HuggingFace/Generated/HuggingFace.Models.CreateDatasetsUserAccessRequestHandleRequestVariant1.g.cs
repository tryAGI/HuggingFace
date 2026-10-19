
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDatasetsUserAccessRequestHandleRequestVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateDatasetsUserAccessRequestHandleRequestVariant1StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant1Status Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejectionReason")]
        public string? RejectionReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resetReason")]
        public string? ResetReason { get; set; }

        /// <summary>
        /// Id of the request as returned by the listing endpoint; the only identifier when the requester's profile is not shared
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetsUserAccessRequestHandleRequestVariant1" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="requestId">
        /// Id of the request as returned by the listing endpoint; the only identifier when the requester's profile is not shared
        /// </param>
        /// <param name="rejectionReason"></param>
        /// <param name="resetReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetsUserAccessRequestHandleRequestVariant1(
            global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant1Status status,
            string requestId,
            string? rejectionReason,
            string? resetReason)
        {
            this.Status = status;
            this.RejectionReason = rejectionReason;
            this.ResetReason = resetReason;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetsUserAccessRequestHandleRequestVariant1" /> class.
        /// </summary>
        public CreateDatasetsUserAccessRequestHandleRequestVariant1()
        {
        }

    }
}