
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutJobsExposeResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PutJobsExposeResponseStatusStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PutJobsExposeResponseStatusStage Stage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.PutJobsExposeResponseStatusCancelReason?, string>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.PutJobsExposeResponseStatusCancelReason?, string>? CancelReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureCount")]
        public double? FailureCount { get; set; }

        /// <summary>
        /// One reachable URL per port declared in `expose.ports`, in the same order (e.g. `https://&lt;job_id&gt;--8000.hf.jobs`). Absent when the job is not exposed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exposeUrls")]
        public global::System.Collections.Generic.IList<string>? ExposeUrls { get; set; }

        /// <summary>
        /// SSH endpoint for the job (e.g. `ssh://&lt;job_id&gt;@ssh.hf.jobs`). Only present when `ssh.enabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sshUrl")]
        public string? SshUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutJobsExposeResponseStatus" /> class.
        /// </summary>
        /// <param name="stage"></param>
        /// <param name="message"></param>
        /// <param name="cancelReason"></param>
        /// <param name="failureCount"></param>
        /// <param name="exposeUrls">
        /// One reachable URL per port declared in `expose.ports`, in the same order (e.g. `https://&lt;job_id&gt;--8000.hf.jobs`). Absent when the job is not exposed.
        /// </param>
        /// <param name="sshUrl">
        /// SSH endpoint for the job (e.g. `ssh://&lt;job_id&gt;@ssh.hf.jobs`). Only present when `ssh.enabled`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutJobsExposeResponseStatus(
            global::HuggingFace.PutJobsExposeResponseStatusStage stage,
            string? message,
            global::HuggingFace.AnyOf<global::HuggingFace.PutJobsExposeResponseStatusCancelReason?, string>? cancelReason,
            double? failureCount,
            global::System.Collections.Generic.IList<string>? exposeUrls,
            string? sshUrl)
        {
            this.Stage = stage;
            this.Message = message;
            this.CancelReason = cancelReason;
            this.FailureCount = failureCount;
            this.ExposeUrls = exposeUrls;
            this.SshUrl = sshUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutJobsExposeResponseStatus" /> class.
        /// </summary>
        public PutJobsExposeResponseStatus()
        {
        }

    }
}