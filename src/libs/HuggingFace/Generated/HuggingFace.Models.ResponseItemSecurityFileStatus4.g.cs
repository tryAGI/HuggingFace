
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemSecurityFileStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemSecurityFileStatusStatus4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemSecurityFileStatusStatus4 Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jFrogScan")]
        public global::HuggingFace.ResponseItemSecurityFileStatusJFrogScan4? JFrogScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectAiScan")]
        public global::HuggingFace.ResponseItemSecurityFileStatusProtectAiScan4? ProtectAiScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemSecurityFileStatusAvScan4 AvScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pickleImportScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemSecurityFileStatusPickleImportScan4 PickleImportScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virusTotalScan")]
        public global::HuggingFace.ResponseItemSecurityFileStatusVirusTotalScan4? VirusTotalScan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemSecurityFileStatus4" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="jFrogScan"></param>
        /// <param name="protectAiScan"></param>
        /// <param name="avScan"></param>
        /// <param name="pickleImportScan"></param>
        /// <param name="virusTotalScan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemSecurityFileStatus4(
            global::HuggingFace.ResponseItemSecurityFileStatusStatus4 status,
            global::HuggingFace.ResponseItemSecurityFileStatusAvScan4 avScan,
            global::HuggingFace.ResponseItemSecurityFileStatusPickleImportScan4 pickleImportScan,
            global::HuggingFace.ResponseItemSecurityFileStatusJFrogScan4? jFrogScan,
            global::HuggingFace.ResponseItemSecurityFileStatusProtectAiScan4? protectAiScan,
            global::HuggingFace.ResponseItemSecurityFileStatusVirusTotalScan4? virusTotalScan)
        {
            this.Status = status;
            this.AvScan = avScan ?? throw new global::System.ArgumentNullException(nameof(avScan));
            this.PickleImportScan = pickleImportScan ?? throw new global::System.ArgumentNullException(nameof(pickleImportScan));
            this.JFrogScan = jFrogScan;
            this.ProtectAiScan = protectAiScan;
            this.VirusTotalScan = virusTotalScan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemSecurityFileStatus4" /> class.
        /// </summary>
        public ResponseItemSecurityFileStatus4()
        {
        }
    }
}