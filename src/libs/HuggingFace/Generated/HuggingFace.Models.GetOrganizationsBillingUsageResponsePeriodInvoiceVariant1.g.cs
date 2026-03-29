
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"stripe"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "stripe";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amountDueCents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AmountDueCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dueDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime DueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionMethod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1CollectionMethodJsonConverter))]
        public global::HuggingFace.GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod? CollectionMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amountDueCents"></param>
        /// <param name="totalCents"></param>
        /// <param name="status"></param>
        /// <param name="dueDate"></param>
        /// <param name="collectionMethod"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1(
            string id,
            double amountDueCents,
            double totalCents,
            global::HuggingFace.GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status status,
            global::System.DateTime dueDate,
            global::HuggingFace.GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod? collectionMethod,
            string type = "stripe")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AmountDueCents = amountDueCents;
            this.TotalCents = totalCents;
            this.Status = status;
            this.DueDate = dueDate;
            this.CollectionMethod = collectionMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1" /> class.
        /// </summary>
        public GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1()
        {
        }
    }
}