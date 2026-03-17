
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemSecurityFileStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemSecurityFileStatusStatus2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemSecurityFileStatusStatus2 Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jFrogScan")]
        public global::HuggingFace.ResponseItemSecurityFileStatusJFrogScan2? JFrogScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectAiScan")]
        public global::HuggingFace.ResponseItemSecurityFileStatusProtectAiScan2? ProtectAiScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemSecurityFileStatusAvScan2 AvScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pickleImportScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemSecurityFileStatusPickleImportScan2 PickleImportScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virusTotalScan")]
        public global::HuggingFace.ResponseItemSecurityFileStatusVirusTotalScan2? VirusTotalScan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemSecurityFileStatus2" /> class.
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
        public ResponseItemSecurityFileStatus2(
            global::HuggingFace.ResponseItemSecurityFileStatusStatus2 status,
            global::HuggingFace.ResponseItemSecurityFileStatusAvScan2 avScan,
            global::HuggingFace.ResponseItemSecurityFileStatusPickleImportScan2 pickleImportScan,
            global::HuggingFace.ResponseItemSecurityFileStatusJFrogScan2? jFrogScan,
            global::HuggingFace.ResponseItemSecurityFileStatusProtectAiScan2? protectAiScan,
            global::HuggingFace.ResponseItemSecurityFileStatusVirusTotalScan2? virusTotalScan)
        {
            this.Status = status;
            this.AvScan = avScan ?? throw new global::System.ArgumentNullException(nameof(avScan));
            this.PickleImportScan = pickleImportScan ?? throw new global::System.ArgumentNullException(nameof(pickleImportScan));
            this.JFrogScan = jFrogScan;
            this.ProtectAiScan = protectAiScan;
            this.VirusTotalScan = virusTotalScan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemSecurityFileStatus2" /> class.
        /// </summary>
        public ResponseItemSecurityFileStatus2()
        {
        }
    }
}