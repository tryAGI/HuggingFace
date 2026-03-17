
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseStatus8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastJob")]
        public global::HuggingFace.ResponseStatusLastJob6? LastJob { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponseStatus8" /> class.
        /// </summary>
        /// <param name="lastJob"></param>
        /// <param name="nextJobRunAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStatus8(
            global::System.DateTime nextJobRunAt,
            global::HuggingFace.ResponseStatusLastJob6? lastJob)
        {
            this.NextJobRunAt = nextJobRunAt;
            this.LastJob = lastJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStatus8" /> class.
        /// </summary>
        public ResponseStatus8()
        {
        }
    }
}