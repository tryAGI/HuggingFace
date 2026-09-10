
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateScheduledJobsRequestJobSpecVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceId")]
        public string? SpaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dockerImage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DockerImage { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateScheduledJobsRequestJobSpecVariant2FlavorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Flavor Flavor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arch")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateScheduledJobsRequestJobSpecVariant2ArchJsonConverter))]
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Arch? Arch { get; set; }

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
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Volume>? Volumes { get; set; }

        /// <summary>
        /// Ports to expose publicly through the jobs proxy. Each port is reachable at `https://&lt;job_id&gt;--&lt;port&gt;.&lt;jobs-public-domain&gt;`. Access requires a HF token with read access to the job's namespace, except for ports also listed in `portsPublic`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expose")]
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Expose? Expose { get; set; }

        /// <summary>
        /// When `enabled`, the job's container is reachable over SSH at `ssh &lt;job_id&gt;@ssh.hf.jobs`. Only the job's owner is allowed in, authenticated by an SSH public key registered on the Hub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh")]
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Ssh? Ssh { get; set; }

        /// <summary>
        /// Opt-in network group. Jobs of the same owner and resource group sharing a group are placed together and reach each other on every port. Two environment variables are set in the container: `HF_NETWORK_GROUP_HOSTNAME`, a hostname resolving to every member of the group, and `HF_NETWORK_GROUP_PREFIX`, to which an alias is appended to get that alias' hostname.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Network? Network { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateScheduledJobsRequestJobSpecVariant2" /> class.
        /// </summary>
        /// <param name="dockerImage"></param>
        /// <param name="flavor"></param>
        /// <param name="spaceId"></param>
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
        public CreateScheduledJobsRequestJobSpecVariant2(
            string dockerImage,
            global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Flavor flavor,
            string? spaceId,
            global::System.Collections.Generic.IList<string>? arguments,
            global::System.Collections.Generic.IList<string>? command,
            global::System.Collections.Generic.Dictionary<string, string>? environment,
            global::System.Collections.Generic.Dictionary<string, string>? secrets,
            global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Arch? arch,
            int? timeoutSeconds,
            int? attempts,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Volume>? volumes,
            global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Expose? expose,
            global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Ssh? ssh,
            global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Network? network,
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
        /// Initializes a new instance of the <see cref="CreateScheduledJobsRequestJobSpecVariant2" /> class.
        /// </summary>
        public CreateScheduledJobsRequestJobSpecVariant2()
        {
        }

    }
}