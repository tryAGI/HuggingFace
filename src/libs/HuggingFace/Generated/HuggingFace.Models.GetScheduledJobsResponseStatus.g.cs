
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetScheduledJobsResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastJob")]
        public global::HuggingFace.GetScheduledJobsResponseStatusLastJob2? LastJob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextJobRunAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime NextJobRunAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScheduledJobsResponseStatus" /> class.
        /// </summary>
        /// <param name="nextJobRunAt"></param>
        /// <param name="lastJob"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetScheduledJobsResponseStatus(
            global::System.DateTime nextJobRunAt,
            global::HuggingFace.GetScheduledJobsResponseStatusLastJob2? lastJob)
        {
            this.LastJob = lastJob;
            this.NextJobRunAt = nextJobRunAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScheduledJobsResponseStatus" /> class.
        /// </summary>
        public GetScheduledJobsResponseStatus()
        {
        }
    }
}