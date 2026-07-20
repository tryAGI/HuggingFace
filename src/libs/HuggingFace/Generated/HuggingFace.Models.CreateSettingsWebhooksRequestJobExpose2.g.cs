
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Ports to expose publicly through the jobs proxy. Each port is reachable at `https://&lt;job_id&gt;--&lt;port&gt;.&lt;jobs-public-domain&gt;`. Access requires a HF token with read access to the job's namespace, except for ports also listed in `portsPublic`.
    /// </summary>
    public sealed partial class CreateSettingsWebhooksRequestJobExpose2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ports")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Ports { get; set; }

        /// <summary>
        /// Subset of `ports` reachable without any authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("portsPublic")]
        public global::System.Collections.Generic.IList<int>? PortsPublic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequestJobExpose2" /> class.
        /// </summary>
        /// <param name="ports"></param>
        /// <param name="portsPublic">
        /// Subset of `ports` reachable without any authentication.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsWebhooksRequestJobExpose2(
            global::System.Collections.Generic.IList<int> ports,
            global::System.Collections.Generic.IList<int>? portsPublic)
        {
            this.Ports = ports ?? throw new global::System.ArgumentNullException(nameof(ports));
            this.PortsPublic = portsPublic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequestJobExpose2" /> class.
        /// </summary>
        public CreateSettingsWebhooksRequestJobExpose2()
        {
        }

    }
}