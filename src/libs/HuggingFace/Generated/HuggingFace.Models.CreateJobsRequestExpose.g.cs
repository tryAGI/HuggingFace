
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// When `enabled`, expose every port the job's container listens on through the jobs proxy. Each port is reachable at `https://&lt;job_id&gt;--&lt;port&gt;.jobs.huggingface.tech`. Any port the container binds to is proxied automatically; you do not need to declare specific ports. Access always requires a HF token with read access to the job's namespace.
    /// </summary>
    public sealed partial class CreateJobsRequestExpose
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobsRequestExpose" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateJobsRequestExpose(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobsRequestExpose" /> class.
        /// </summary>
        public CreateJobsRequestExpose()
        {
        }

    }
}