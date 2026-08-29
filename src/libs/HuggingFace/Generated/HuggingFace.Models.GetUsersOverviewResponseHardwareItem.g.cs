
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsersOverviewResponseHardwareItem
    {
        /// <summary>
        /// Hardware SKU as [type, vendor, model]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sku")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Sku { get; set; }

        /// <summary>
        /// Memory in GB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Mem { get; set; }

        /// <summary>
        /// Number of units
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Num { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPrimary")]
        public string? IsPrimary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersOverviewResponseHardwareItem" /> class.
        /// </summary>
        /// <param name="sku">
        /// Hardware SKU as [type, vendor, model]
        /// </param>
        /// <param name="mem">
        /// Memory in GB
        /// </param>
        /// <param name="num">
        /// Number of units
        /// </param>
        /// <param name="isPrimary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsersOverviewResponseHardwareItem(
            global::System.Collections.Generic.IList<string> sku,
            double mem,
            double num,
            string? isPrimary)
        {
            this.Sku = sku ?? throw new global::System.ArgumentNullException(nameof(sku));
            this.Mem = mem;
            this.Num = num;
            this.IsPrimary = isPrimary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersOverviewResponseHardwareItem" /> class.
        /// </summary>
        public GetUsersOverviewResponseHardwareItem()
        {
        }

    }
}