
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemSecurityFileStatus6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemSecurityFileStatusStatus6JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemSecurityFileStatusStatus6 Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jFrogScan")]
        public global::HuggingFace.ResponseItemSecurityFileStatusJFrogScan6? JFrogScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectAiScan")]
        public global::HuggingFace.ResponseItemSecurityFileStatusProtectAiScan6? ProtectAiScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemSecurityFileStatusAvScan6 AvScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pickleImportScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemSecurityFileStatusPickleImportScan6 PickleImportScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virusTotalScan")]
        public global::HuggingFace.ResponseItemSecurityFileStatusVirusTotalScan6? VirusTotalScan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemSecurityFileStatus6" /> class.
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
        public ResponseItemSecurityFileStatus6(
            global::HuggingFace.ResponseItemSecurityFileStatusStatus6 status,
            global::HuggingFace.ResponseItemSecurityFileStatusAvScan6 avScan,
            global::HuggingFace.ResponseItemSecurityFileStatusPickleImportScan6 pickleImportScan,
            global::HuggingFace.ResponseItemSecurityFileStatusJFrogScan6? jFrogScan,
            global::HuggingFace.ResponseItemSecurityFileStatusProtectAiScan6? protectAiScan,
            global::HuggingFace.ResponseItemSecurityFileStatusVirusTotalScan6? virusTotalScan)
        {
            this.Status = status;
            this.AvScan = avScan ?? throw new global::System.ArgumentNullException(nameof(avScan));
            this.PickleImportScan = pickleImportScan ?? throw new global::System.ArgumentNullException(nameof(pickleImportScan));
            this.JFrogScan = jFrogScan;
            this.ProtectAiScan = protectAiScan;
            this.VirusTotalScan = virusTotalScan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemSecurityFileStatus6" /> class.
        /// </summary>
        public ResponseItemSecurityFileStatus6()
        {
        }
    }
}