
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseWebhookJob3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dockerImage")]
        public string? DockerImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceId")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Environment { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flavor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseWebhookJobFlavor3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseWebhookJobFlavor3 Flavor { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Labels for the job as key-value pairs. Both keys and values must be max 100 characters and contain only alphanumeric characters, dots, dashes, and underscores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<string>? Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebhookJob3" /> class.
        /// </summary>
        /// <param name="dockerImage"></param>
        /// <param name="spaceId"></param>
        /// <param name="environment">
        /// Default Value: {}
        /// </param>
        /// <param name="arguments"></param>
        /// <param name="command"></param>
        /// <param name="flavor"></param>
        /// <param name="timeoutSeconds">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="labels">
        /// Labels for the job as key-value pairs. Both keys and values must be max 100 characters and contain only alphanumeric characters, dots, dashes, and underscores.
        /// </param>
        /// <param name="secrets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseWebhookJob3(
            global::System.Collections.Generic.Dictionary<string, string> environment,
            global::HuggingFace.ResponseWebhookJobFlavor3 flavor,
            string? dockerImage,
            string? spaceId,
            global::System.Collections.Generic.IList<string>? arguments,
            global::System.Collections.Generic.IList<string>? command,
            int? timeoutSeconds,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            global::System.Collections.Generic.IList<string>? secrets)
        {
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Flavor = flavor;
            this.DockerImage = dockerImage;
            this.SpaceId = spaceId;
            this.Arguments = arguments;
            this.Command = command;
            this.TimeoutSeconds = timeoutSeconds;
            this.Labels = labels;
            this.Secrets = secrets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebhookJob3" /> class.
        /// </summary>
        public ResponseWebhookJob3()
        {
        }
    }
}