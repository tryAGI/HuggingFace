
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateJobsResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateJobsResponseStatusStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateJobsResponseStatusStage Stage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateJobsResponseStatusCancelReason?, string>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateJobsResponseStatusCancelReason?, string>? CancelReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureCount")]
        public double? FailureCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobsResponseStatus" /> class.
        /// </summary>
        /// <param name="stage"></param>
        /// <param name="message"></param>
        /// <param name="cancelReason"></param>
        /// <param name="failureCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateJobsResponseStatus(
            global::HuggingFace.CreateJobsResponseStatusStage stage,
            string? message,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateJobsResponseStatusCancelReason?, string>? cancelReason,
            double? failureCount)
        {
            this.Stage = stage;
            this.Message = message;
            this.CancelReason = cancelReason;
            this.FailureCount = failureCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobsResponseStatus" /> class.
        /// </summary>
        public CreateJobsResponseStatus()
        {
        }
    }
}