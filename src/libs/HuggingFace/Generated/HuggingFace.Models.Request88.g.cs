
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request88
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobSpec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.RequestJobSpec JobSpec { get; set; }

        /// <summary>
        /// CRON schedule expression (e.g., '0 9 * * 1' for 9 AM every Monday).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Schedule { get; set; }

        /// <summary>
        /// Whether the scheduled job is suspended (paused)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspend")]
        public bool? Suspend { get; set; }

        /// <summary>
        /// Whether multiple instances of this job can run concurrently<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public bool? Concurrency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request88" /> class.
        /// </summary>
        /// <param name="jobSpec"></param>
        /// <param name="schedule">
        /// CRON schedule expression (e.g., '0 9 * * 1' for 9 AM every Monday).
        /// </param>
        /// <param name="suspend">
        /// Whether the scheduled job is suspended (paused)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="concurrency">
        /// Whether multiple instances of this job can run concurrently<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request88(
            global::HuggingFace.RequestJobSpec jobSpec,
            string schedule,
            bool? suspend,
            bool? concurrency)
        {
            this.JobSpec = jobSpec ?? throw new global::System.ArgumentNullException(nameof(jobSpec));
            this.Schedule = schedule ?? throw new global::System.ArgumentNullException(nameof(schedule));
            this.Suspend = suspend;
            this.Concurrency = concurrency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request88" /> class.
        /// </summary>
        public Request88()
        {
        }
    }
}