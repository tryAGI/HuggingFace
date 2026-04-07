
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateJobsCancelResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateJobsCancelResponseStatusStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateJobsCancelResponseStatusStage Stage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateJobsCancelResponseStatusCancelReason?, string>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateJobsCancelResponseStatusCancelReason?, string>? CancelReason { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateJobsCancelResponseStatus" /> class.
        /// </summary>
        /// <param name="stage"></param>
        /// <param name="message"></param>
        /// <param name="cancelReason"></param>
        /// <param name="failureCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateJobsCancelResponseStatus(
            global::HuggingFace.CreateJobsCancelResponseStatusStage stage,
            string? message,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateJobsCancelResponseStatusCancelReason?, string>? cancelReason,
            double? failureCount)
        {
            this.Stage = stage;
            this.Message = message;
            this.CancelReason = cancelReason;
            this.FailureCount = failureCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobsCancelResponseStatus" /> class.
        /// </summary>
        public CreateJobsCancelResponseStatus()
        {
        }
    }
}