
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpacesPathsInfoResponseItemSecurityFileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jFrogScan")]
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScan? JFrogScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectAiScan")]
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScan? ProtectAiScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScan AvScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pickleImportScan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScan PickleImportScan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virusTotalScan")]
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScan? VirusTotalScan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpacesPathsInfoResponseItemSecurityFileStatus" /> class.
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
        public CreateSpacesPathsInfoResponseItemSecurityFileStatus(
            global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus status,
            global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScan avScan,
            global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScan pickleImportScan,
            global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScan? jFrogScan,
            global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScan? protectAiScan,
            global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScan? virusTotalScan)
        {
            this.Status = status;
            this.JFrogScan = jFrogScan;
            this.ProtectAiScan = protectAiScan;
            this.AvScan = avScan ?? throw new global::System.ArgumentNullException(nameof(avScan));
            this.PickleImportScan = pickleImportScan ?? throw new global::System.ArgumentNullException(nameof(pickleImportScan));
            this.VirusTotalScan = virusTotalScan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpacesPathsInfoResponseItemSecurityFileStatus" /> class.
        /// </summary>
        public CreateSpacesPathsInfoResponseItemSecurityFileStatus()
        {
        }
    }
}