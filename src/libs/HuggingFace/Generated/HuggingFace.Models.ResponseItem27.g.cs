
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItem27
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prettyName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrettyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ram")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ram { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accelerator")]
        public global::HuggingFace.ResponseItemAccelerator4? Accelerator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitCostMicroUSD")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UnitCostMicroUSD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitCostUSD")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UnitCostUSD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitLabel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UnitLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem27" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="prettyName"></param>
        /// <param name="cpu"></param>
        /// <param name="ram"></param>
        /// <param name="accelerator"></param>
        /// <param name="unitCostMicroUSD"></param>
        /// <param name="unitCostUSD"></param>
        /// <param name="unitLabel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItem27(
            string name,
            string prettyName,
            string cpu,
            string ram,
            double unitCostMicroUSD,
            double unitCostUSD,
            string unitLabel,
            global::HuggingFace.ResponseItemAccelerator4? accelerator)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PrettyName = prettyName ?? throw new global::System.ArgumentNullException(nameof(prettyName));
            this.Cpu = cpu ?? throw new global::System.ArgumentNullException(nameof(cpu));
            this.Ram = ram ?? throw new global::System.ArgumentNullException(nameof(ram));
            this.UnitCostMicroUSD = unitCostMicroUSD;
            this.UnitCostUSD = unitCostUSD;
            this.UnitLabel = unitLabel ?? throw new global::System.ArgumentNullException(nameof(unitLabel));
            this.Accelerator = accelerator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem27" /> class.
        /// </summary>
        public ResponseItem27()
        {
        }
    }
}