
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseUsageItem2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseUsageItemProduct2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseUsageItemProduct2 Product { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stoppedAt")]
        public global::System.DateTime? StoppedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freeGrant")]
        public bool? FreeGrant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productPrettyName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductPrettyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitLabel")]
        public string? UnitLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCostMicroUSD")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCostMicroUSD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitCostMicroUSD")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UnitCostMicroUSD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageItem2" /> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="label"></param>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        /// <param name="startedAt"></param>
        /// <param name="stoppedAt"></param>
        /// <param name="freeGrant"></param>
        /// <param name="productPrettyName"></param>
        /// <param name="unitLabel"></param>
        /// <param name="totalCostMicroUSD"></param>
        /// <param name="unitCostMicroUSD"></param>
        /// <param name="active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseUsageItem2(
            string entityId,
            global::HuggingFace.ResponseUsageItemProduct2 product,
            double quantity,
            string productPrettyName,
            double totalCostMicroUSD,
            double unitCostMicroUSD,
            bool active,
            string? label,
            global::System.DateTime? startedAt,
            global::System.DateTime? stoppedAt,
            bool? freeGrant,
            string? unitLabel)
        {
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.Product = product;
            this.Quantity = quantity;
            this.ProductPrettyName = productPrettyName ?? throw new global::System.ArgumentNullException(nameof(productPrettyName));
            this.TotalCostMicroUSD = totalCostMicroUSD;
            this.UnitCostMicroUSD = unitCostMicroUSD;
            this.Active = active;
            this.Label = label;
            this.StartedAt = startedAt;
            this.StoppedAt = stoppedAt;
            this.FreeGrant = freeGrant;
            this.UnitLabel = unitLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageItem2" /> class.
        /// </summary>
        public ResponseUsageItem2()
        {
        }
    }
}