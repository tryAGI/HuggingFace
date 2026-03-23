
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateScheduledJobsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Schedule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Suspend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Concurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateScheduledJobsResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"scheduled-job"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "scheduled-job";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateScheduledJobsResponseOwner Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initiator")]
        public global::HuggingFace.CreateScheduledJobsResponseInitiator? Initiator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobSpec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateScheduledJobsResponseJobSpec JobSpec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduledJobsResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="schedule"></param>
        /// <param name="suspend"></param>
        /// <param name="concurrency"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="owner"></param>
        /// <param name="initiator"></param>
        /// <param name="jobSpec"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateScheduledJobsResponse(
            string id,
            global::System.DateTime createdAt,
            string schedule,
            bool suspend,
            bool concurrency,
            global::HuggingFace.CreateScheduledJobsResponseStatus status,
            global::HuggingFace.CreateScheduledJobsResponseOwner owner,
            global::HuggingFace.CreateScheduledJobsResponseJobSpec jobSpec,
            global::HuggingFace.CreateScheduledJobsResponseInitiator? initiator,
            string type = "scheduled-job")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Schedule = schedule ?? throw new global::System.ArgumentNullException(nameof(schedule));
            this.Suspend = suspend;
            this.Concurrency = concurrency;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.JobSpec = jobSpec ?? throw new global::System.ArgumentNullException(nameof(jobSpec));
            this.Type = type;
            this.Initiator = initiator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduledJobsResponse" /> class.
        /// </summary>
        public CreateScheduledJobsResponse()
        {
        }
    }
}