
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemVariant2AvailableInferenceProvider5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemVariant2AvailableInferenceProviderProvider5JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderProvider5 Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemVariant2AvailableInferenceProviderProviderStatus5JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderProviderStatus5 ProviderStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemVariant2AvailableInferenceProviderModelStatus5JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderModelStatus5 ModelStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemVariant2AvailableInferenceProviderTask5JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderTask5 Task { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapterType")]
        public string? AdapterType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapterWeightsPath")]
        public string? AdapterWeightsPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderFeatures5? Features { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCheapestPricingOutput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCheapestPricingOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFastestThroughput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFastestThroughput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isModelAuthor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsModelAuthor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokensPerSecond")]
        public double? TokensPerSecond { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingOutput")]
        public double? PricingOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant2AvailableInferenceProvider5" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="providerStatus"></param>
        /// <param name="modelStatus"></param>
        /// <param name="providerId"></param>
        /// <param name="task"></param>
        /// <param name="adapterType"></param>
        /// <param name="adapterWeightsPath"></param>
        /// <param name="features"></param>
        /// <param name="isCheapestPricingOutput"></param>
        /// <param name="isFastestThroughput"></param>
        /// <param name="isModelAuthor"></param>
        /// <param name="tokensPerSecond"></param>
        /// <param name="pricingOutput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemVariant2AvailableInferenceProvider5(
            global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderProvider5 provider,
            global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderProviderStatus5 providerStatus,
            global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderModelStatus5 modelStatus,
            string providerId,
            global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderTask5 task,
            bool isCheapestPricingOutput,
            bool isFastestThroughput,
            bool isModelAuthor,
            string? adapterType,
            string? adapterWeightsPath,
            global::HuggingFace.ResponseItemVariant2AvailableInferenceProviderFeatures5? features,
            double? tokensPerSecond,
            double? pricingOutput)
        {
            this.Provider = provider;
            this.ProviderStatus = providerStatus;
            this.ModelStatus = modelStatus;
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.Task = task;
            this.IsCheapestPricingOutput = isCheapestPricingOutput;
            this.IsFastestThroughput = isFastestThroughput;
            this.IsModelAuthor = isModelAuthor;
            this.AdapterType = adapterType;
            this.AdapterWeightsPath = adapterWeightsPath;
            this.Features = features;
            this.TokensPerSecond = tokensPerSecond;
            this.PricingOutput = pricingOutput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant2AvailableInferenceProvider5" /> class.
        /// </summary>
        public ResponseItemVariant2AvailableInferenceProvider5()
        {
        }
    }
}