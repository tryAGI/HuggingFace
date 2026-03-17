
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseDataItemVariant3Runtime2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseDataItemVariant3RuntimeStage2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseDataItemVariant3RuntimeStage2 Stage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseDataItemVariant3RuntimeHardware2 Hardware { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        public global::HuggingFace.ResponseDataItemVariant3RuntimeStorage4? Storage { get; set; }

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
        public required global::HuggingFace.ResponseDataItemVariant3RuntimeReplicas2 Replicas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devMode")]
        public bool? DevMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<global::HuggingFace.ResponseDataItemVariant3RuntimeDomain2>? Domains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hotReloading")]
        public global::HuggingFace.ResponseDataItemVariant3RuntimeHotReloading2? HotReloading { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDataItemVariant3Runtime2" /> class.
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
        public ResponseDataItemVariant3Runtime2(
            global::HuggingFace.ResponseDataItemVariant3RuntimeStage2 stage,
            global::HuggingFace.ResponseDataItemVariant3RuntimeHardware2 hardware,
            global::HuggingFace.ResponseDataItemVariant3RuntimeReplicas2 replicas,
            global::HuggingFace.ResponseDataItemVariant3RuntimeStorage4? storage,
            string? errorMessage,
            double? gcTimeout,
            bool? devMode,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseDataItemVariant3RuntimeDomain2>? domains,
            string? sha,
            global::HuggingFace.ResponseDataItemVariant3RuntimeHotReloading2? hotReloading)
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
        /// Initializes a new instance of the <see cref="ResponseDataItemVariant3Runtime2" /> class.
        /// </summary>
        public ResponseDataItemVariant3Runtime2()
        {
        }
    }
}