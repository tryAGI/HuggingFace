
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafetyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety Safety { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport" /> class.
        /// </summary>
        /// <param name="module"></param>
        /// <param name="name"></param>
        /// <param name="safety"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport(
            string module,
            string name,
            global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety safety)
        {
            this.Module = module ?? throw new global::System.ArgumentNullException(nameof(module));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Safety = safety;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport" /> class.
        /// </summary>
        public GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport()
        {
        }
    }
}