
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetJobsHardwareResponseItemAccelerator2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetJobsHardwareResponseItemAcceleratorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetJobsHardwareResponseItemAcceleratorType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vram")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Vram { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manufacturer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetJobsHardwareResponseItemAcceleratorManufacturerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer Manufacturer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetJobsHardwareResponseItemAccelerator2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="model"></param>
        /// <param name="quantity"></param>
        /// <param name="vram"></param>
        /// <param name="manufacturer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetJobsHardwareResponseItemAccelerator2(
            global::HuggingFace.GetJobsHardwareResponseItemAcceleratorType type,
            string model,
            string quantity,
            string vram,
            global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer manufacturer)
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Quantity = quantity ?? throw new global::System.ArgumentNullException(nameof(quantity));
            this.Vram = vram ?? throw new global::System.ArgumentNullException(nameof(vram));
            this.Manufacturer = manufacturer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetJobsHardwareResponseItemAccelerator2" /> class.
        /// </summary>
        public GetJobsHardwareResponseItemAccelerator2()
        {
        }
    }
}