
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDatasetsUserAccessRequestHandleRequestVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateDatasetsUserAccessRequestHandleRequestVariant2StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant2Status Status { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetsUserAccessRequestHandleRequestVariant2" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="userId"></param>
        /// <param name="rejectionReason"></param>
        /// <param name="resetReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetsUserAccessRequestHandleRequestVariant2(
            global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant2Status status,
            string userId,
            string? rejectionReason,
            string? resetReason)
        {
            this.Status = status;
            this.RejectionReason = rejectionReason;
            this.ResetReason = resetReason;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetsUserAccessRequestHandleRequestVariant2" /> class.
        /// </summary>
        public CreateDatasetsUserAccessRequestHandleRequestVariant2()
        {
        }

    }
}