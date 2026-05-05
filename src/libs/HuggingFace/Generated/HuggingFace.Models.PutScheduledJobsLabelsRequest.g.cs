
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutScheduledJobsLabelsRequest
    {
        /// <summary>
        /// The new labels to set on the job. Replaces all existing labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutScheduledJobsLabelsRequest" /> class.
        /// </summary>
        /// <param name="labels">
        /// The new labels to set on the job. Replaces all existing labels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutScheduledJobsLabelsRequest(
            global::System.Collections.Generic.Dictionary<string, string> labels)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutScheduledJobsLabelsRequest" /> class.
        /// </summary>
        public PutScheduledJobsLabelsRequest()
        {
        }
    }
}