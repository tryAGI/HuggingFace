
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetModelsUserAccessRequestResponseItem
    {
        /// <summary>
        /// Id of the request, usable to accept/reject it even when the requester identity is not shared
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Absent when the requester's profile is not shared
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemUser? User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantedBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1, global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1, global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant2>? GrantedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetModelsUserAccessRequestResponseItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetModelsUserAccessRequestResponseItemStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.Dictionary<string, string>? Fields { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewedAt")]
        public global::System.DateTime? ReviewedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsUserAccessRequestResponseItem" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Id of the request, usable to accept/reject it even when the requester identity is not shared
        /// </param>
        /// <param name="status"></param>
        /// <param name="timestamp"></param>
        /// <param name="user">
        /// Absent when the requester's profile is not shared
        /// </param>
        /// <param name="grantedBy"></param>
        /// <param name="fields"></param>
        /// <param name="reviewedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsUserAccessRequestResponseItem(
            string requestId,
            global::HuggingFace.GetModelsUserAccessRequestResponseItemStatus status,
            global::System.DateTime timestamp,
            global::HuggingFace.GetModelsUserAccessRequestResponseItemUser? user,
            global::HuggingFace.AnyOf<global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1, global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant2>? grantedBy,
            global::System.Collections.Generic.Dictionary<string, string>? fields,
            global::System.DateTime? reviewedAt)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.User = user;
            this.GrantedBy = grantedBy;
            this.Status = status;
            this.Fields = fields;
            this.Timestamp = timestamp;
            this.ReviewedAt = reviewedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsUserAccessRequestResponseItem" /> class.
        /// </summary>
        public GetModelsUserAccessRequestResponseItem()
        {
        }

    }
}