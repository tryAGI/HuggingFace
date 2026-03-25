
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage Stage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardware Hardware { get; set; }

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
        public required global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeReplicas Replicas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devMode")]
        public bool? DevMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain>? Domains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hotReloading")]
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHotReloading? HotReloading { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolume>? Volumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntime" /> class.
        /// </summary>
        /// <param name="stage"></param>
        /// <param name="hardware"></param>
        /// <param name="errorMessage"></param>
        /// <param name="gcTimeout"></param>
        /// <param name="replicas"></param>
        /// <param name="devMode"></param>
        /// <param name="domains"></param>
        /// <param name="sha"></param>
        /// <param name="hotReloading"></param>
        /// <param name="volumes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntime(
            global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage stage,
            global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardware hardware,
            global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeReplicas replicas,
            string? errorMessage,
            double? gcTimeout,
            bool? devMode,
            global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain>? domains,
            string? sha,
            global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHotReloading? hotReloading,
            global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolume>? volumes)
        {
            this.Stage = stage;
            this.Hardware = hardware ?? throw new global::System.ArgumentNullException(nameof(hardware));
            this.Replicas = replicas ?? throw new global::System.ArgumentNullException(nameof(replicas));
            this.ErrorMessage = errorMessage;
            this.GcTimeout = gcTimeout;
            this.DevMode = devMode;
            this.Domains = domains;
            this.Sha = sha;
            this.HotReloading = hotReloading;
            this.Volumes = volumes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntime" /> class.
        /// </summary>
        public GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntime()
        {
        }
    }
}