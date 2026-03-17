
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseUsage3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedMicroUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsedMicroUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalMinutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodStart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PeriodStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodEnd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PeriodEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobDetails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseUsageJobDetail> JobDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsage3" /> class.
        /// </summary>
        /// <param name="usedMicroUsd"></param>
        /// <param name="totalMinutes"></param>
        /// <param name="periodStart"></param>
        /// <param name="periodEnd"></param>
        /// <param name="jobDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseUsage3(
            double usedMicroUsd,
            double totalMinutes,
            global::System.DateTime periodStart,
            global::System.DateTime periodEnd,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseUsageJobDetail> jobDetails)
        {
            this.UsedMicroUsd = usedMicroUsd;
            this.TotalMinutes = totalMinutes;
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.JobDetails = jobDetails ?? throw new global::System.ArgumentNullException(nameof(jobDetails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsage3" /> class.
        /// </summary>
        public ResponseUsage3()
        {
        }
    }
}