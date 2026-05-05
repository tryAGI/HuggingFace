
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutJobsLabelsResponseDurations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedulingSecs")]
        public double? SchedulingSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runningSecs")]
        public double? RunningSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSecs")]
        public double? TotalSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutJobsLabelsResponseDurations" /> class.
        /// </summary>
        /// <param name="schedulingSecs"></param>
        /// <param name="runningSecs"></param>
        /// <param name="totalSecs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutJobsLabelsResponseDurations(
            double? schedulingSecs,
            double? runningSecs,
            double? totalSecs)
        {
            this.SchedulingSecs = schedulingSecs;
            this.RunningSecs = runningSecs;
            this.TotalSecs = totalSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutJobsLabelsResponseDurations" /> class.
        /// </summary>
        public PutJobsLabelsResponseDurations()
        {
        }
    }
}