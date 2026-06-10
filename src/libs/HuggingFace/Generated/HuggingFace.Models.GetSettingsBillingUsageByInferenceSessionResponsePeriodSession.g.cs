
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSettingsBillingUsageByInferenceSessionResponsePeriodSession
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSettingsBillingUsageByInferenceSessionResponsePeriodSession" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestCount"></param>
        /// <param name="costCents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSettingsBillingUsageByInferenceSessionResponsePeriodSession(
            string id,
            double requestCount,
            double costCents)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RequestCount = requestCount;
            this.CostCents = costCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSettingsBillingUsageByInferenceSessionResponsePeriodSession" /> class.
        /// </summary>
        public GetSettingsBillingUsageByInferenceSessionResponsePeriodSession()
        {
        }

    }
}