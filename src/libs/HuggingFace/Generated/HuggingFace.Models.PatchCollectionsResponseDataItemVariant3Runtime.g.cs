
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchCollectionsResponseDataItemVariant3Runtime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchCollectionsResponseDataItemVariant3RuntimeStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStage Stage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardware Hardware { get; set; }

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
        public required global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeReplicas Replicas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devMode")]
        public bool? DevMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain>? Domains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hotReloading")]
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHotReloading? HotReloading { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeVolume>? Volumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant3Runtime" /> class.
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
        /// <param name="volumes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchCollectionsResponseDataItemVariant3Runtime(
            global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStage stage,
            global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardware hardware,
            global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeReplicas replicas,
            string? errorMessage,
            double? gcTimeout,
            bool? devMode,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain>? domains,
            string? sha,
            global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHotReloading? hotReloading,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeVolume>? volumes)
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
            this.Volumes = volumes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant3Runtime" /> class.
        /// </summary>
        public PatchCollectionsResponseDataItemVariant3Runtime()
        {
        }
    }
}