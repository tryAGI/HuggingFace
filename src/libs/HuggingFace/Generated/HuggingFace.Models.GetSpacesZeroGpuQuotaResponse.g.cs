
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSpacesZeroGpuQuotaResponse
    {
        /// <summary>
        /// Total quota in GPU-seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Base { get; set; }

        /// <summary>
        /// Remaining quota in GPU-seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Current { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the quota resets, or null if the quota has not been used yet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resetsAt")]
        public global::System.DateTime? ResetsAt { get; set; }

        /// <summary>
        /// Overquota (paid) GPU-seconds consumed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overquotaUsed")]
        public double? OverquotaUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesZeroGpuQuotaResponse" /> class.
        /// </summary>
        /// <param name="base">
        /// Total quota in GPU-seconds
        /// </param>
        /// <param name="current">
        /// Remaining quota in GPU-seconds
        /// </param>
        /// <param name="resetsAt">
        /// ISO 8601 timestamp when the quota resets, or null if the quota has not been used yet
        /// </param>
        /// <param name="overquotaUsed">
        /// Overquota (paid) GPU-seconds consumed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSpacesZeroGpuQuotaResponse(
            double @base,
            double current,
            global::System.DateTime? resetsAt,
            double? overquotaUsed)
        {
            this.Base = @base;
            this.Current = current;
            this.ResetsAt = resetsAt;
            this.OverquotaUsed = overquotaUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesZeroGpuQuotaResponse" /> class.
        /// </summary>
        public GetSpacesZeroGpuQuotaResponse()
        {
        }

    }
}