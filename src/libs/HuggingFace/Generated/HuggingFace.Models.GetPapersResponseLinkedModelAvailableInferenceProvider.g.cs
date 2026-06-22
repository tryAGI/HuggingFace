
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPapersResponseLinkedModelAvailableInferenceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAvailableInferenceProviderProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus ProviderStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus ModelStatus { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAvailableInferenceProviderTaskJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderTask Task { get; set; }

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
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderFeatures? Features { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freeUntil")]
        public global::System.DateTime? FreeUntil { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPapersResponseLinkedModelAvailableInferenceProvider" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="providerStatus"></param>
        /// <param name="modelStatus"></param>
        /// <param name="providerId"></param>
        /// <param name="task"></param>
        /// <param name="isCheapestPricingOutput"></param>
        /// <param name="isFastestThroughput"></param>
        /// <param name="isModelAuthor"></param>
        /// <param name="adapterType"></param>
        /// <param name="adapterWeightsPath"></param>
        /// <param name="features"></param>
        /// <param name="tokensPerSecond"></param>
        /// <param name="pricingOutput"></param>
        /// <param name="freeUntil"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPapersResponseLinkedModelAvailableInferenceProvider(
            global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProvider provider,
            global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus providerStatus,
            global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus modelStatus,
            string providerId,
            global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderTask task,
            bool isCheapestPricingOutput,
            bool isFastestThroughput,
            bool isModelAuthor,
            string? adapterType,
            string? adapterWeightsPath,
            global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderFeatures? features,
            double? tokensPerSecond,
            double? pricingOutput,
            global::System.DateTime? freeUntil)
        {
            this.Provider = provider;
            this.ProviderStatus = providerStatus;
            this.ModelStatus = modelStatus;
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.Task = task;
            this.AdapterType = adapterType;
            this.AdapterWeightsPath = adapterWeightsPath;
            this.Features = features;
            this.IsCheapestPricingOutput = isCheapestPricingOutput;
            this.IsFastestThroughput = isFastestThroughput;
            this.IsModelAuthor = isModelAuthor;
            this.TokensPerSecond = tokensPerSecond;
            this.PricingOutput = pricingOutput;
            this.FreeUntil = freeUntil;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPapersResponseLinkedModelAvailableInferenceProvider" /> class.
        /// </summary>
        public GetPapersResponseLinkedModelAvailableInferenceProvider()
        {
        }

    }
}