
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
        /// One reachable URL per declared port in `expose.ports`, in the same order. Access requires an HF token with read access to the job's namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exposeUrls")]
        public global::System.Collections.Generic.IList<string>? ExposeUrls { get; set; }

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
        /// <param name="exposeUrls">
        /// One reachable URL per declared port in `expose.ports`, in the same order. Access requires an HF token with read access to the job's namespace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateJobsCancelResponseStatus(
            global::HuggingFace.CreateJobsCancelResponseStatusStage stage,
            string? message,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateJobsCancelResponseStatusCancelReason?, string>? cancelReason,
            double? failureCount,
            global::System.Collections.Generic.IList<string>? exposeUrls)
        {
            this.Stage = stage;
            this.Message = message;
            this.CancelReason = cancelReason;
            this.FailureCount = failureCount;
            this.ExposeUrls = exposeUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobsCancelResponseStatus" /> class.
        /// </summary>
        public CreateJobsCancelResponseStatus()
        {
        }

    }
}