
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSettingsBillingUsageResponsePeriod
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
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetSettingsBillingUsageResponsePeriodEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetSettingsBillingUsageResponsePeriodEntityType EntityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodStart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PeriodStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodEnd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PeriodEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetSettingsBillingUsageResponsePeriodInvoiceVariant1, global::HuggingFace.GetSettingsBillingUsageResponsePeriodInvoiceVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.GetSettingsBillingUsageResponsePeriodInvoiceVariant1, global::HuggingFace.GetSettingsBillingUsageResponsePeriodInvoiceVariant2>? Invoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charges")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingUsageResponsePeriodCharge>? Charges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSettingsBillingUsageResponsePeriod" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entityId"></param>
        /// <param name="entityType"></param>
        /// <param name="entityName"></param>
        /// <param name="periodStart"></param>
        /// <param name="periodEnd"></param>
        /// <param name="invoice"></param>
        /// <param name="charges"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSettingsBillingUsageResponsePeriod(
            string id,
            string entityId,
            global::HuggingFace.GetSettingsBillingUsageResponsePeriodEntityType entityType,
            string entityName,
            global::System.DateTime periodStart,
            global::System.DateTime periodEnd,
            global::HuggingFace.AnyOf<global::HuggingFace.GetSettingsBillingUsageResponsePeriodInvoiceVariant1, global::HuggingFace.GetSettingsBillingUsageResponsePeriodInvoiceVariant2>? invoice,
            global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingUsageResponsePeriodCharge>? charges)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.EntityType = entityType;
            this.EntityName = entityName ?? throw new global::System.ArgumentNullException(nameof(entityName));
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.Invoice = invoice;
            this.Charges = charges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSettingsBillingUsageResponsePeriod" /> class.
        /// </summary>
        public GetSettingsBillingUsageResponsePeriod()
        {
        }
    }
}