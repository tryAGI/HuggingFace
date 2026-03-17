
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Job
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.JobOwner Owner { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public global::System.Collections.Generic.IList<string>? Command { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::System.Collections.Generic.IList<string>? Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arch")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.JobArchJsonConverter))]
        public global::HuggingFace.JobArch? Arch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flavor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.JobFlavorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.JobFlavor Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.JobStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.JobCreatedBy CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry")]
        public double? Retry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::HuggingFace.JobVolume>? Volumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="owner"></param>
        /// <param name="spaceId"></param>
        /// <param name="dockerImage"></param>
        /// <param name="timeout"></param>
        /// <param name="environment"></param>
        /// <param name="secrets"></param>
        /// <param name="command"></param>
        /// <param name="arguments"></param>
        /// <param name="arch"></param>
        /// <param name="flavor"></param>
        /// <param name="status"></param>
        /// <param name="createdBy"></param>
        /// <param name="tags"></param>
        /// <param name="retry"></param>
        /// <param name="volumes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Job(
            string id,
            global::System.DateTime createdAt,
            global::HuggingFace.JobOwner owner,
            global::System.Collections.Generic.Dictionary<string, string> environment,
            global::HuggingFace.JobFlavor flavor,
            global::HuggingFace.JobStatus status,
            global::HuggingFace.JobCreatedBy createdBy,
            string? spaceId,
            string? dockerImage,
            double? timeout,
            global::System.Collections.Generic.Dictionary<string, object?>? secrets,
            global::System.Collections.Generic.IList<string>? command,
            global::System.Collections.Generic.IList<string>? arguments,
            global::HuggingFace.JobArch? arch,
            global::System.Collections.Generic.IList<string>? tags,
            double? retry,
            global::System.Collections.Generic.IList<global::HuggingFace.JobVolume>? volumes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Flavor = flavor;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.SpaceId = spaceId;
            this.DockerImage = dockerImage;
            this.Timeout = timeout;
            this.Secrets = secrets;
            this.Command = command;
            this.Arguments = arguments;
            this.Arch = arch;
            this.Tags = tags;
            this.Retry = retry;
            this.Volumes = volumes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        public Job()
        {
        }
    }
}