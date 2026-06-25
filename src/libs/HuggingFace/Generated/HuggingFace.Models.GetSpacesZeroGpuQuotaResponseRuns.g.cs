
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Execution (runs) accounting, or omitted for visitors without a runs limit
    /// </summary>
    public sealed partial class GetSpacesZeroGpuQuotaResponseRuns
    {
        /// <summary>
        /// Executions used in the current runs window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Used { get; set; }

        /// <summary>
        /// Maximum number of executions allowed in the runs window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// Executions left before the runs limit is reached
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Remaining { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the runs window resets, or null if no run has happened yet. Independent of resetsAt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resetsAt")]
        public global::System.DateTime? ResetsAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesZeroGpuQuotaResponseRuns" /> class.
        /// </summary>
        /// <param name="used">
        /// Executions used in the current runs window
        /// </param>
        /// <param name="limit">
        /// Maximum number of executions allowed in the runs window
        /// </param>
        /// <param name="remaining">
        /// Executions left before the runs limit is reached
        /// </param>
        /// <param name="resetsAt">
        /// ISO 8601 timestamp when the runs window resets, or null if no run has happened yet. Independent of resetsAt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSpacesZeroGpuQuotaResponseRuns(
            double used,
            double limit,
            double remaining,
            global::System.DateTime? resetsAt)
        {
            this.Used = used;
            this.Limit = limit;
            this.Remaining = remaining;
            this.ResetsAt = resetsAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesZeroGpuQuotaResponseRuns" /> class.
        /// </summary>
        public GetSpacesZeroGpuQuotaResponseRuns()
        {
        }

    }
}