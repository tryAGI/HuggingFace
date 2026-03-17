
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Info
    {
        /// <summary>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("docker_label")]
        public string? DockerLabel { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_best_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxBestOf { get; set; }

        /// <summary>
        /// Example: 32
        /// </summary>
        /// <example>32</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_client_batch_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxClientBatchSize { get; set; }

        /// <summary>
        /// Router Parameters<br/>
        /// Example: 128
        /// </summary>
        /// <example>128</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxConcurrentRequests { get; set; }

        /// <summary>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxInputTokens { get; set; }

        /// <summary>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_stop_sequences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxStopSequences { get; set; }

        /// <summary>
        /// Example: 2048
        /// </summary>
        /// <example>2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTotalTokens { get; set; }

        /// <summary>
        /// Model info<br/>
        /// Example: bigscience/blomm-560m
        /// </summary>
        /// <example>bigscience/blomm-560m</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Example: text-generation
        /// </summary>
        /// <example>text-generation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_pipeline_tag")]
        public string? ModelPipelineTag { get; set; }

        /// <summary>
        /// Example: e985a63cdc139290c5f700ff1929f0b5942cced2
        /// </summary>
        /// <example>e985a63cdc139290c5f700ff1929f0b5942cced2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_sha")]
        public string? ModelSha { get; set; }

        /// <summary>
        /// Router Info<br/>
        /// Example: text-generation-router
        /// </summary>
        /// <example>text-generation-router</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("router")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Router { get; set; }

        /// <summary>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_workers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ValidationWorkers { get; set; }

        /// <summary>
        /// Example: 0.5.0
        /// </summary>
        /// <example>0.5.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Info" /> class.
        /// </summary>
        /// <param name="dockerLabel">
        /// Example: null
        /// </param>
        /// <param name="maxBestOf">
        /// Example: 2
        /// </param>
        /// <param name="maxClientBatchSize">
        /// Example: 32
        /// </param>
        /// <param name="maxConcurrentRequests">
        /// Router Parameters<br/>
        /// Example: 128
        /// </param>
        /// <param name="maxInputTokens">
        /// Example: 1024
        /// </param>
        /// <param name="maxStopSequences">
        /// Example: 4
        /// </param>
        /// <param name="maxTotalTokens">
        /// Example: 2048
        /// </param>
        /// <param name="modelId">
        /// Model info<br/>
        /// Example: bigscience/blomm-560m
        /// </param>
        /// <param name="modelPipelineTag">
        /// Example: text-generation
        /// </param>
        /// <param name="modelSha">
        /// Example: e985a63cdc139290c5f700ff1929f0b5942cced2
        /// </param>
        /// <param name="router">
        /// Router Info<br/>
        /// Example: text-generation-router
        /// </param>
        /// <param name="sha">
        /// Example: null
        /// </param>
        /// <param name="validationWorkers">
        /// Example: 2
        /// </param>
        /// <param name="version">
        /// Example: 0.5.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Info(
            int maxBestOf,
            int maxClientBatchSize,
            int maxConcurrentRequests,
            int maxInputTokens,
            int maxStopSequences,
            int maxTotalTokens,
            string modelId,
            string router,
            int validationWorkers,
            string version,
            string? dockerLabel,
            string? modelPipelineTag,
            string? modelSha,
            string? sha)
        {
            this.MaxBestOf = maxBestOf;
            this.MaxClientBatchSize = maxClientBatchSize;
            this.MaxConcurrentRequests = maxConcurrentRequests;
            this.MaxInputTokens = maxInputTokens;
            this.MaxStopSequences = maxStopSequences;
            this.MaxTotalTokens = maxTotalTokens;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Router = router ?? throw new global::System.ArgumentNullException(nameof(router));
            this.ValidationWorkers = validationWorkers;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.DockerLabel = dockerLabel;
            this.ModelPipelineTag = modelPipelineTag;
            this.ModelSha = modelSha;
            this.Sha = sha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Info" /> class.
        /// </summary>
        public Info()
        {
        }
    }
}