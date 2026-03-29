
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetsUserAccessRequestHandleRequest
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateDatasetsUserAccessRequestHandleRequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestStatus Status { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateDatasetsUserAccessRequestHandleRequest" /> class.
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
        public CreateDatasetsUserAccessRequestHandleRequest(
            global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestStatus status,
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
        /// Initializes a new instance of the <see cref="CreateDatasetsUserAccessRequestHandleRequest" /> class.
        /// </summary>
        public CreateDatasetsUserAccessRequestHandleRequest()
        {
        }
    }
}