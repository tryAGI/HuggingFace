
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastJob")]
        public global::HuggingFace.ResponseItemStatusLastJob2? LastJob { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponseItemStatus4" /> class.
        /// </summary>
        /// <param name="lastJob"></param>
        /// <param name="nextJobRunAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemStatus4(
            global::System.DateTime nextJobRunAt,
            global::HuggingFace.ResponseItemStatusLastJob2? lastJob)
        {
            this.NextJobRunAt = nextJobRunAt;
            this.LastJob = lastJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemStatus4" /> class.
        /// </summary>
        public ResponseItemStatus4()
        {
        }
    }
}