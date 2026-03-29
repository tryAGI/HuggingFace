
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSettingsWebhooksRequestJob2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobFlavor2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateSettingsWebhooksRequestJobFlavor2 Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arch")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateSettingsWebhooksRequestJobArch2JsonConverter))]
        public global::HuggingFace.CreateSettingsWebhooksRequestJobArch2? Arch { get; set; }

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
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVolume2>? Volumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequestJob2" /> class.
        /// </summary>
        /// <param name="flavor"></param>
        /// <param name="spaceId"></param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsWebhooksRequestJob2(
            global::HuggingFace.CreateSettingsWebhooksRequestJobFlavor2 flavor,
            string? spaceId,
            string? dockerImage,
            global::System.Collections.Generic.IList<string>? arguments,
            global::System.Collections.Generic.IList<string>? command,
            global::System.Collections.Generic.Dictionary<string, string>? environment,
            global::System.Collections.Generic.Dictionary<string, string>? secrets,
            global::HuggingFace.CreateSettingsWebhooksRequestJobArch2? arch,
            int? timeoutSeconds,
            int? attempts,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVolume2>? volumes)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequestJob2" /> class.
        /// </summary>
        public CreateSettingsWebhooksRequestJob2()
        {
        }
    }
}