
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetsPathsInfoResponseItemSecurityFileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jFrogScan")]
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScan? JFrogScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectAiScan")]
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScan? ProtectAiScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScan AvScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pickleImportScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScan PickleImportScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virusTotalScan")]
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScan? VirusTotalScan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetsPathsInfoResponseItemSecurityFileStatus" /> class.
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
        public CreateDatasetsPathsInfoResponseItemSecurityFileStatus(
            global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus status,
            global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScan avScan,
            global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScan pickleImportScan,
            global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScan? jFrogScan,
            global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScan? protectAiScan,
            global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScan? virusTotalScan)
        {
            this.Status = status;
            this.JFrogScan = jFrogScan;
            this.ProtectAiScan = protectAiScan;
            this.AvScan = avScan ?? throw new global::System.ArgumentNullException(nameof(avScan));
            this.PickleImportScan = pickleImportScan ?? throw new global::System.ArgumentNullException(nameof(pickleImportScan));
            this.VirusTotalScan = virusTotalScan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetsPathsInfoResponseItemSecurityFileStatus" /> class.
        /// </summary>
        public CreateDatasetsPathsInfoResponseItemSecurityFileStatus()
        {
        }
    }
}