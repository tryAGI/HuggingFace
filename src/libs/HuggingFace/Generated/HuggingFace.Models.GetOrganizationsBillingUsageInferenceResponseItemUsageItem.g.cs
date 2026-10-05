
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationsBillingUsageInferenceResponseItemUsageItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costCents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CostCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedInputTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CachedInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageInferenceResponseItemUsageItem" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="requestCount"></param>
        /// <param name="costCents"></param>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="cachedInputTokens"></param>
        /// <param name="user"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsBillingUsageInferenceResponseItemUsageItem(
            string provider,
            double requestCount,
            double costCents,
            double inputTokens,
            double outputTokens,
            double cachedInputTokens,
            string? user,
            string? model)
        {
            this.User = user;
            this.Model = model;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.RequestCount = requestCount;
            this.CostCents = costCents;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CachedInputTokens = cachedInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageInferenceResponseItemUsageItem" /> class.
        /// </summary>
        public GetOrganizationsBillingUsageInferenceResponseItemUsageItem()
        {
        }

    }
}