
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemSecurityFileStatusJFrogScanPickleImport2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("module")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Module { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2 Safety { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemSecurityFileStatusJFrogScanPickleImport2" /> class.
        /// </summary>
        /// <param name="module"></param>
        /// <param name="name"></param>
        /// <param name="safety"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemSecurityFileStatusJFrogScanPickleImport2(
            string module,
            string name,
            global::HuggingFace.ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2 safety)
        {
            this.Module = module ?? throw new global::System.ArgumentNullException(nameof(module));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Safety = safety;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemSecurityFileStatusJFrogScanPickleImport2" /> class.
        /// </summary>
        public ResponseItemSecurityFileStatusJFrogScanPickleImport2()
        {
        }
    }
}