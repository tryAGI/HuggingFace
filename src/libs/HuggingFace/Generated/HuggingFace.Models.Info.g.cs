
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Info
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_truncate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoTruncate { get; set; }

        /// <summary>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("docker_label")]
        public string? DockerLabel { get; set; }

        /// <summary>
        /// Default Value: null<br/>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_batch_requests")]
        public int? MaxBatchRequests { get; set; }

        /// <summary>
        /// Example: 2048
        /// </summary>
        /// <example>2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_batch_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxBatchTokens { get; set; }

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
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_input_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxInputLength { get; set; }

        /// <summary>
        /// Example: float16
        /// </summary>
        /// <example>float16</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_dtype")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelDtype { get; set; }

        /// <summary>
        /// Model info<br/>
        /// Example: thenlper/gte-base
        /// </summary>
        /// <example>thenlper/gte-base</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Example: fca14538aa9956a46526bd1d0d11d69e19b5a101
        /// </summary>
        /// <example>fca14538aa9956a46526bd1d0d11d69e19b5a101</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_sha")]
        public string? ModelSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ModelTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ModelType ModelType { get; set; }

        /// <summary>
        /// Example: thenlper/gte-base
        /// </summary>
        /// <example>thenlper/gte-base</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("served_model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServedModelName { get; set; }

        /// <summary>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenization_workers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TokenizationWorkers { get; set; }

        /// <summary>
        /// Router Info<br/>
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
        /// <param name="autoTruncate"></param>
        /// <param name="dockerLabel">
        /// Example: null
        /// </param>
        /// <param name="maxBatchRequests">
        /// Default Value: null<br/>
        /// Example: null
        /// </param>
        /// <param name="maxBatchTokens">
        /// Example: 2048
        /// </param>
        /// <param name="maxClientBatchSize">
        /// Example: 32
        /// </param>
        /// <param name="maxConcurrentRequests">
        /// Router Parameters<br/>
        /// Example: 128
        /// </param>
        /// <param name="maxInputLength">
        /// Example: 512
        /// </param>
        /// <param name="modelDtype">
        /// Example: float16
        /// </param>
        /// <param name="modelId">
        /// Model info<br/>
        /// Example: thenlper/gte-base
        /// </param>
        /// <param name="modelSha">
        /// Example: fca14538aa9956a46526bd1d0d11d69e19b5a101
        /// </param>
        /// <param name="modelType"></param>
        /// <param name="servedModelName">
        /// Example: thenlper/gte-base
        /// </param>
        /// <param name="sha">
        /// Example: null
        /// </param>
        /// <param name="tokenizationWorkers">
        /// Example: 4
        /// </param>
        /// <param name="version">
        /// Router Info<br/>
        /// Example: 0.5.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Info(
            bool autoTruncate,
            int maxBatchTokens,
            int maxClientBatchSize,
            int maxConcurrentRequests,
            int maxInputLength,
            string modelDtype,
            string modelId,
            global::HuggingFace.ModelType modelType,
            string servedModelName,
            int tokenizationWorkers,
            string version,
            string? dockerLabel,
            int? maxBatchRequests,
            string? modelSha,
            string? sha)
        {
            this.AutoTruncate = autoTruncate;
            this.MaxBatchTokens = maxBatchTokens;
            this.MaxClientBatchSize = maxClientBatchSize;
            this.MaxConcurrentRequests = maxConcurrentRequests;
            this.MaxInputLength = maxInputLength;
            this.ModelDtype = modelDtype ?? throw new global::System.ArgumentNullException(nameof(modelDtype));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelType = modelType;
            this.ServedModelName = servedModelName ?? throw new global::System.ArgumentNullException(nameof(servedModelName));
            this.TokenizationWorkers = tokenizationWorkers;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.DockerLabel = dockerLabel;
            this.MaxBatchRequests = maxBatchRequests;
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