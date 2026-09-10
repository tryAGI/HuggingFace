
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSettingsWebhooksRequestJobVariant12
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dockerImage")]
        public string? DockerImage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::System.Collections.Generic.IList<string>? Arguments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public global::System.Collections.Generic.IList<string>? Command { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public global::System.Collections.Generic.Dictionary<string, string>? Environment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.Dictionary<string, string>? Secrets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flavor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1Flavor2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor2 Flavor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arch")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobVariant1Arch2JsonConverter))]
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch2? Arch { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Max number of attempts to make. For example, if you set this to 3, the job will be retried up to 2 times if it fails.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        public int? Attempts { get; set; }

        /// <summary>
        /// Labels for the job as key-value pairs. Both keys and values must be max 100 characters and contain only alphanumeric characters, dots, dashes, and underscores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// HuggingFace Buckets or Repos to mount as volumes in the job container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume2>? Volumes { get; set; }

        /// <summary>
        /// Ports to expose publicly through the jobs proxy. Each port is reachable at `https://&lt;job_id&gt;--&lt;port&gt;.&lt;jobs-public-domain&gt;`. Access requires a HF token with read access to the job's namespace, except for ports also listed in `portsPublic`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expose")]
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Expose2? Expose { get; set; }

        /// <summary>
        /// When `enabled`, the job's container is reachable over SSH at `ssh &lt;job_id&gt;@ssh.hf.jobs`. Only the job's owner is allowed in, authenticated by an SSH public key registered on the Hub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh")]
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Ssh2? Ssh { get; set; }

        /// <summary>
        /// Opt-in network group. Jobs of the same owner and resource group sharing a group are placed together and reach each other on every port. Two environment variables are set in the container: `HF_NETWORK_GROUP_HOSTNAME`, a hostname resolving to every member of the group, and `HF_NETWORK_GROUP_PREFIX`, to which an alias is appended to get that alias' hostname.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Network2? Network { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroupId")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequestJobVariant12" /> class.
        /// </summary>
        /// <param name="spaceId"></param>
        /// <param name="flavor"></param>
        /// <param name="dockerImage"></param>
        /// <param name="arguments"></param>
        /// <param name="command"></param>
        /// <param name="environment">
        /// Default Value: {}
        /// </param>
        /// <param name="secrets"></param>
        /// <param name="arch"></param>
        /// <param name="timeoutSeconds">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="attempts">
        /// Max number of attempts to make. For example, if you set this to 3, the job will be retried up to 2 times if it fails.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="labels">
        /// Labels for the job as key-value pairs. Both keys and values must be max 100 characters and contain only alphanumeric characters, dots, dashes, and underscores.
        /// </param>
        /// <param name="volumes">
        /// HuggingFace Buckets or Repos to mount as volumes in the job container.
        /// </param>
        /// <param name="expose">
        /// Ports to expose publicly through the jobs proxy. Each port is reachable at `https://&lt;job_id&gt;--&lt;port&gt;.&lt;jobs-public-domain&gt;`. Access requires a HF token with read access to the job's namespace, except for ports also listed in `portsPublic`.
        /// </param>
        /// <param name="ssh">
        /// When `enabled`, the job's container is reachable over SSH at `ssh &lt;job_id&gt;@ssh.hf.jobs`. Only the job's owner is allowed in, authenticated by an SSH public key registered on the Hub.
        /// </param>
        /// <param name="network">
        /// Opt-in network group. Jobs of the same owner and resource group sharing a group are placed together and reach each other on every port. Two environment variables are set in the container: `HF_NETWORK_GROUP_HOSTNAME`, a hostname resolving to every member of the group, and `HF_NETWORK_GROUP_PREFIX`, to which an alias is appended to get that alias' hostname.
        /// </param>
        /// <param name="resourceGroupId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsWebhooksRequestJobVariant12(
            string spaceId,
            global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor2 flavor,
            string? dockerImage,
            global::System.Collections.Generic.IList<string>? arguments,
            global::System.Collections.Generic.IList<string>? command,
            global::System.Collections.Generic.Dictionary<string, string>? environment,
            global::System.Collections.Generic.Dictionary<string, string>? secrets,
            global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch2? arch,
            int? timeoutSeconds,
            int? attempts,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume2>? volumes,
            global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Expose2? expose,
            global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Ssh2? ssh,
            global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Network2? network,
            string? resourceGroupId)
        {
            this.SpaceId = spaceId;
            this.DockerImage = dockerImage;
            this.Arguments = arguments;
            this.Command = command;
            this.Environment = environment;
            this.Secrets = secrets;
            this.Flavor = flavor;
            this.Arch = arch;
            this.TimeoutSeconds = timeoutSeconds;
            this.Attempts = attempts;
            this.Labels = labels;
            this.Volumes = volumes;
            this.Expose = expose;
            this.Ssh = ssh;
            this.Network = network;
            this.ResourceGroupId = resourceGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequestJobVariant12" /> class.
        /// </summary>
        public CreateSettingsWebhooksRequestJobVariant12()
        {
        }

    }
}