
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCollectionsResponseItemVariant3Runtime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateCollectionsResponseItemVariant3RuntimeStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeStage Stage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeHardware Hardware { get; set; }

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
        public required global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeReplicas Replicas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devMode")]
        public bool? DevMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeDomain>? Domains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hotReloading")]
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeHotReloading? HotReloading { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResponseItemVariant3Runtime" /> class.
        /// </summary>
        /// <param name="stage"></param>
        /// <param name="hardware"></param>
        /// <param name="replicas"></param>
        /// <param name="errorMessage"></param>
        /// <param name="gcTimeout"></param>
        /// <param name="devMode"></param>
        /// <param name="domains"></param>
        /// <param name="sha"></param>
        /// <param name="hotReloading"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsResponseItemVariant3Runtime(
            global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeStage stage,
            global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeHardware hardware,
            global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeReplicas replicas,
            string? errorMessage,
            double? gcTimeout,
            bool? devMode,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeDomain>? domains,
            string? sha,
            global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeHotReloading? hotReloading)
        {
            this.Stage = stage;
            this.Hardware = hardware ?? throw new global::System.ArgumentNullException(nameof(hardware));
            this.ErrorMessage = errorMessage;
            this.GcTimeout = gcTimeout;
            this.Replicas = replicas ?? throw new global::System.ArgumentNullException(nameof(replicas));
            this.DevMode = devMode;
            this.Domains = domains;
            this.Sha = sha;
            this.HotReloading = hotReloading;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResponseItemVariant3Runtime" /> class.
        /// </summary>
        public CreateCollectionsResponseItemVariant3Runtime()
        {
        }
    }
}