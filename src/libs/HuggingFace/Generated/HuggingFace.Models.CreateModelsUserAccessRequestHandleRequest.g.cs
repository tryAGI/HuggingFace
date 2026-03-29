
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelsUserAccessRequestHandleRequest
    {
        /// <summary>
        /// Either userId or user must be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Either userId or user must be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateModelsUserAccessRequestHandleRequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateModelsUserAccessRequestHandleRequestStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejectionReason")]
        public string? RejectionReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsUserAccessRequestHandleRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="userId">
        /// Either userId or user must be provided
        /// </param>
        /// <param name="user">
        /// Either userId or user must be provided
        /// </param>
        /// <param name="rejectionReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelsUserAccessRequestHandleRequest(
            global::HuggingFace.CreateModelsUserAccessRequestHandleRequestStatus status,
            string? userId,
            string? user,
            string? rejectionReason)
        {
            this.UserId = userId;
            this.User = user;
            this.Status = status;
            this.RejectionReason = rejectionReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsUserAccessRequestHandleRequest" /> class.
        /// </summary>
        public CreateModelsUserAccessRequestHandleRequest()
        {
        }
    }
}