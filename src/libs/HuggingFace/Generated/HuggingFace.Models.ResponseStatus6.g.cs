
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseStatus6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastJob")]
        public global::HuggingFace.ResponseStatusLastJob4? LastJob { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponseStatus6" /> class.
        /// </summary>
        /// <param name="lastJob"></param>
        /// <param name="nextJobRunAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStatus6(
            global::System.DateTime nextJobRunAt,
            global::HuggingFace.ResponseStatusLastJob4? lastJob)
        {
            this.NextJobRunAt = nextJobRunAt;
            this.LastJob = lastJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStatus6" /> class.
        /// </summary>
        public ResponseStatus6()
        {
        }
    }
}