
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseVariant1ItemItemVariant3Runtime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseVariant1ItemItemVariant3RuntimeStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeStage Stage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeHardware Hardware { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        public global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeStorage2? Storage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gcTimeout")]
        public double? GcTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeReplicas Replicas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devMode")]
        public bool? DevMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeDomain>? Domains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hotReloading")]
        public global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeHotReloading? HotReloading { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1ItemItemVariant3Runtime" /> class.
        /// </summary>
        /// <param name="stage"></param>
        /// <param name="hardware"></param>
        /// <param name="storage"></param>
        /// <param name="errorMessage"></param>
        /// <param name="gcTimeout"></param>
        /// <param name="replicas"></param>
        /// <param name="devMode"></param>
        /// <param name="domains"></param>
        /// <param name="sha"></param>
        /// <param name="hotReloading"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseVariant1ItemItemVariant3Runtime(
            global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeStage stage,
            global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeHardware hardware,
            global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeReplicas replicas,
            global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeStorage2? storage,
            string? errorMessage,
            double? gcTimeout,
            bool? devMode,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeDomain>? domains,
            string? sha,
            global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeHotReloading? hotReloading)
        {
            this.Stage = stage;
            this.Hardware = hardware ?? throw new global::System.ArgumentNullException(nameof(hardware));
            this.Replicas = replicas ?? throw new global::System.ArgumentNullException(nameof(replicas));
            this.Storage = storage;
            this.ErrorMessage = errorMessage;
            this.GcTimeout = gcTimeout;
            this.DevMode = devMode;
            this.Domains = domains;
            this.Sha = sha;
            this.HotReloading = hotReloading;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1ItemItemVariant3Runtime" /> class.
        /// </summary>
        public ResponseVariant1ItemItemVariant3Runtime()
        {
        }
    }
}