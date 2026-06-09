
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Ports to expose publicly through the jobs proxy. Each port is reachable at `https://&lt;job_id&gt;--&lt;port&gt;.&lt;jobs-public-domain&gt;`. Access always requires a HF token with read access to the job's namespace.
    /// </summary>
    public sealed partial class CreateSettingsWebhooksRequestJobExpose
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ports")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Ports { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequestJobExpose" /> class.
        /// </summary>
        /// <param name="ports"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsWebhooksRequestJobExpose(
            global::System.Collections.Generic.IList<int> ports)
        {
            this.Ports = ports ?? throw new global::System.ArgumentNullException(nameof(ports));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequestJobExpose" /> class.
        /// </summary>
        public CreateSettingsWebhooksRequestJobExpose()
        {
        }

    }
}