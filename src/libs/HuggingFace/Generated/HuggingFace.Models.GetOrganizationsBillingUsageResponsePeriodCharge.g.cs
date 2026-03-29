
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsBillingUsageResponsePeriodCharge
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dueDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime DueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageAtChargeTimeMicroUSD")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsageAtChargeTimeMicroUSD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amountCents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AmountCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billedThrough")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsBillingUsageResponsePeriodChargeBilledThroughJsonConverter))]
        public global::HuggingFace.GetOrganizationsBillingUsageResponsePeriodChargeBilledThrough BilledThrough { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paymentIntentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PaymentIntentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paymentIntentStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus PaymentIntentStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageResponsePeriodCharge" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="dueDate"></param>
        /// <param name="usageAtChargeTimeMicroUSD"></param>
        /// <param name="amountCents"></param>
        /// <param name="paymentIntentId"></param>
        /// <param name="paymentIntentStatus"></param>
        /// <param name="billedThrough"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsBillingUsageResponsePeriodCharge(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime dueDate,
            double usageAtChargeTimeMicroUSD,
            double amountCents,
            string paymentIntentId,
            global::HuggingFace.GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus paymentIntentStatus,
            global::HuggingFace.GetOrganizationsBillingUsageResponsePeriodChargeBilledThrough billedThrough)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.DueDate = dueDate;
            this.UsageAtChargeTimeMicroUSD = usageAtChargeTimeMicroUSD;
            this.AmountCents = amountCents;
            this.BilledThrough = billedThrough;
            this.PaymentIntentId = paymentIntentId ?? throw new global::System.ArgumentNullException(nameof(paymentIntentId));
            this.PaymentIntentStatus = paymentIntentStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageResponsePeriodCharge" /> class.
        /// </summary>
        public GetOrganizationsBillingUsageResponsePeriodCharge()
        {
        }
    }
}