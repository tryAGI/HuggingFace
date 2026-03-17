
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseUsageJobDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardwareFlavor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HardwareFlavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalMinutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCostMicroUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCostMicroUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageJobDetail" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="hardwareFlavor"></param>
        /// <param name="totalMinutes"></param>
        /// <param name="totalCostMicroUsd"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseUsageJobDetail(
            string jobId,
            string hardwareFlavor,
            double totalMinutes,
            double totalCostMicroUsd,
            global::System.DateTime startedAt,
            global::System.DateTime? completedAt)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.HardwareFlavor = hardwareFlavor ?? throw new global::System.ArgumentNullException(nameof(hardwareFlavor));
            this.TotalMinutes = totalMinutes;
            this.TotalCostMicroUsd = totalCostMicroUsd;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageJobDetail" /> class.
        /// </summary>
        public ResponseUsageJobDetail()
        {
        }
    }
}