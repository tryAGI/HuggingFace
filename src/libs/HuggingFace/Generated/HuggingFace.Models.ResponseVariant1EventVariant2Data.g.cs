
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseVariant1EventVariant2Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseVariant1EventVariant2DataStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseVariant1EventVariant2DataStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1EventVariant2Data" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseVariant1EventVariant2Data(
            global::HuggingFace.ResponseVariant1EventVariant2DataStatus status,
            string? reason)
        {
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1EventVariant2Data" /> class.
        /// </summary>
        public ResponseVariant1EventVariant2Data()
        {
        }
    }
}