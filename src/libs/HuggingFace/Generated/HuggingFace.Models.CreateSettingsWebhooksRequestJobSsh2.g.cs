
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// When `enabled`, the job's container is reachable over SSH at `ssh &lt;job_id&gt;@ssh.hf.jobs`. Only the job's owner is allowed in, authenticated by an SSH public key registered on the Hub.
    /// </summary>
    public sealed partial class CreateSettingsWebhooksRequestJobSsh2
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
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequestJobSsh2" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsWebhooksRequestJobSsh2(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequestJobSsh2" /> class.
        /// </summary>
        public CreateSettingsWebhooksRequestJobSsh2()
        {
        }

    }
}