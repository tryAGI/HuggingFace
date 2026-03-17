
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response128
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseArchJsonConverter))]
        public global::HuggingFace.ResponseArch? Arch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flavor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseFlavorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseFlavor Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseCreatedBy CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry")]
        public double? Retry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::HuggingFace.ResponseVolume>? Volumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"job"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "job";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseOwner Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initiator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.ResponseInitiatorVariant1, global::HuggingFace.ResponseInitiatorVariant2, global::HuggingFace.ResponseInitiatorVariant3, global::HuggingFace.ResponseInitiatorVariant4>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.ResponseInitiatorVariant1, global::HuggingFace.ResponseInitiatorVariant2, global::HuggingFace.ResponseInitiatorVariant3, global::HuggingFace.ResponseInitiatorVariant4>? Initiator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<string>? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hfToken")]
        public global::HuggingFace.ResponseHfToken? HfToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response128" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="spaceId"></param>
        /// <param name="dockerImage"></param>
        /// <param name="timeout"></param>
        /// <param name="environment"></param>
        /// <param name="command"></param>
        /// <param name="arguments"></param>
        /// <param name="arch"></param>
        /// <param name="flavor"></param>
        /// <param name="createdBy"></param>
        /// <param name="retry"></param>
        /// <param name="volumes"></param>
        /// <param name="type"></param>
        /// <param name="owner"></param>
        /// <param name="initiator"></param>
        /// <param name="status"></param>
        /// <param name="secrets"></param>
        /// <param name="labels"></param>
        /// <param name="hfToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response128(
            string id,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.Dictionary<string, string> environment,
            global::HuggingFace.ResponseFlavor flavor,
            global::HuggingFace.ResponseCreatedBy createdBy,
            global::HuggingFace.ResponseOwner owner,
            global::HuggingFace.ResponseStatus status,
            string? spaceId,
            string? dockerImage,
            double? timeout,
            global::System.Collections.Generic.IList<string>? command,
            global::System.Collections.Generic.IList<string>? arguments,
            global::HuggingFace.ResponseArch? arch,
            double? retry,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseVolume>? volumes,
            global::HuggingFace.AnyOf<global::HuggingFace.ResponseInitiatorVariant1, global::HuggingFace.ResponseInitiatorVariant2, global::HuggingFace.ResponseInitiatorVariant3, global::HuggingFace.ResponseInitiatorVariant4>? initiator,
            global::System.Collections.Generic.IList<string>? secrets,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            global::HuggingFace.ResponseHfToken? hfToken,
            string type = "job")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Flavor = flavor;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.SpaceId = spaceId;
            this.DockerImage = dockerImage;
            this.Timeout = timeout;
            this.Command = command;
            this.Arguments = arguments;
            this.Arch = arch;
            this.Retry = retry;
            this.Volumes = volumes;
            this.Type = type;
            this.Initiator = initiator;
            this.Secrets = secrets;
            this.Labels = labels;
            this.HfToken = hfToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response128" /> class.
        /// </summary>
        public Response128()
        {
        }
    }
}