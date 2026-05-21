
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelsLfsFilesDuplicateResponseFailedItem2
    {
        /// <summary>
        /// Xet content hash of the file that failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xetHash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XetHash { get; set; }

        /// <summary>
        /// sha256 of the file that failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha256 { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsLfsFilesDuplicateResponseFailedItem2" /> class.
        /// </summary>
        /// <param name="xetHash">
        /// Xet content hash of the file that failed
        /// </param>
        /// <param name="sha256">
        /// sha256 of the file that failed
        /// </param>
        /// <param name="error">
        /// Error message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelsLfsFilesDuplicateResponseFailedItem2(
            string xetHash,
            string sha256,
            string error)
        {
            this.XetHash = xetHash ?? throw new global::System.ArgumentNullException(nameof(xetHash));
            this.Sha256 = sha256 ?? throw new global::System.ArgumentNullException(nameof(sha256));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsLfsFilesDuplicateResponseFailedItem2" /> class.
        /// </summary>
        public CreateModelsLfsFilesDuplicateResponseFailedItem2()
        {
        }

    }
}