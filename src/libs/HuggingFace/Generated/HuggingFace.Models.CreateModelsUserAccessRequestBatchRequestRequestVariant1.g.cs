
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateModelsUserAccessRequestBatchRequestRequestVariant1
    {
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
        /// Initializes a new instance of the <see cref="CreateModelsUserAccessRequestBatchRequestRequestVariant1" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Id of the request as returned by the listing endpoint; the only identifier when the requester's profile is not shared
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelsUserAccessRequestBatchRequestRequestVariant1(
            string requestId)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsUserAccessRequestBatchRequestRequestVariant1" /> class.
        /// </summary>
        public CreateModelsUserAccessRequestBatchRequestRequestVariant1()
        {
        }

    }
}