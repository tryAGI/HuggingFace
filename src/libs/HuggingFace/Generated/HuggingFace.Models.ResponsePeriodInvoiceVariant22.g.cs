
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsePeriodInvoiceVariant22
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"no-invoice"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "no-invoice";

        /// <summary>
        /// 
        /// </summary>
        /// <default>"no-invoice"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "no-invoice";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsePeriodInvoiceVariant22" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsePeriodInvoiceVariant22(
            string type = "no-invoice",
            string id = "no-invoice")
        {
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsePeriodInvoiceVariant22" /> class.
        /// </summary>
        public ResponsePeriodInvoiceVariant22()
        {
        }
    }
}