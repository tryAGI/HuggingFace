
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelsTreeResponseItemSecurityFileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jFrogScan")]
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScan? JFrogScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectAiScan")]
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScan? ProtectAiScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScan AvScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pickleImportScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScan PickleImportScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virusTotalScan")]
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScan? VirusTotalScan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsTreeResponseItemSecurityFileStatus" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="avScan"></param>
        /// <param name="pickleImportScan"></param>
        /// <param name="jFrogScan"></param>
        /// <param name="protectAiScan"></param>
        /// <param name="virusTotalScan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsTreeResponseItemSecurityFileStatus(
            global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusStatus status,
            global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScan avScan,
            global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScan pickleImportScan,
            global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScan? jFrogScan,
            global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScan? protectAiScan,
            global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScan? virusTotalScan)
        {
            this.Status = status;
            this.JFrogScan = jFrogScan;
            this.ProtectAiScan = protectAiScan;
            this.AvScan = avScan ?? throw new global::System.ArgumentNullException(nameof(avScan));
            this.PickleImportScan = pickleImportScan ?? throw new global::System.ArgumentNullException(nameof(pickleImportScan));
            this.VirusTotalScan = virusTotalScan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsTreeResponseItemSecurityFileStatus" /> class.
        /// </summary>
        public GetModelsTreeResponseItemSecurityFileStatus()
        {
        }
    }
}