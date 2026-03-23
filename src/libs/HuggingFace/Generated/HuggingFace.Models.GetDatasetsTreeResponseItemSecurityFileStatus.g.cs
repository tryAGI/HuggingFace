
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetsTreeResponseItemSecurityFileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetDatasetsTreeResponseItemSecurityFileStatusStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jFrogScan")]
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScan? JFrogScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectAiScan")]
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScan? ProtectAiScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScan AvScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pickleImportScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScan PickleImportScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virusTotalScan")]
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScan? VirusTotalScan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetsTreeResponseItemSecurityFileStatus" /> class.
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
        public GetDatasetsTreeResponseItemSecurityFileStatus(
            global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusStatus status,
            global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScan avScan,
            global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScan pickleImportScan,
            global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScan? jFrogScan,
            global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScan? protectAiScan,
            global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScan? virusTotalScan)
        {
            this.Status = status;
            this.AvScan = avScan ?? throw new global::System.ArgumentNullException(nameof(avScan));
            this.PickleImportScan = pickleImportScan ?? throw new global::System.ArgumentNullException(nameof(pickleImportScan));
            this.JFrogScan = jFrogScan;
            this.ProtectAiScan = protectAiScan;
            this.VirusTotalScan = virusTotalScan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetsTreeResponseItemSecurityFileStatus" /> class.
        /// </summary>
        public GetDatasetsTreeResponseItemSecurityFileStatus()
        {
        }
    }
}