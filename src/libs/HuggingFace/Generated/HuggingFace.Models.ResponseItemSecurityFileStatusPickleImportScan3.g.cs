
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemSecurityFileStatusPickleImportScan3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemSecurityFileStatusPickleImportScanStatus3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemSecurityFileStatusPickleImportScanStatus3 Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reportLink")]
        public string? ReportLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reportLabel")]
        public string? ReportLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pickleImports")]
        public global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemSecurityFileStatusPickleImportScanPickleImport3>? PickleImports { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemSecurityFileStatusPickleImportScan3" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="reportLink"></param>
        /// <param name="reportLabel"></param>
        /// <param name="pickleImports"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemSecurityFileStatusPickleImportScan3(
            global::HuggingFace.ResponseItemSecurityFileStatusPickleImportScanStatus3 status,
            string? message,
            string? reportLink,
            string? reportLabel,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemSecurityFileStatusPickleImportScanPickleImport3>? pickleImports,
            string? version)
        {
            this.Status = status;
            this.Message = message;
            this.ReportLink = reportLink;
            this.ReportLabel = reportLabel;
            this.PickleImports = pickleImports;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemSecurityFileStatusPickleImportScan3" /> class.
        /// </summary>
        public ResponseItemSecurityFileStatusPickleImportScan3()
        {
        }
    }
}