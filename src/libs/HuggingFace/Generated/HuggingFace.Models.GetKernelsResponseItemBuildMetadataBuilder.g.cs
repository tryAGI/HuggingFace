
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetKernelsResponseItemBuildMetadataBuilder
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        public string? Commit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dirty")]
        public bool? Dirty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKernelsResponseItemBuildMetadataBuilder" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="commit"></param>
        /// <param name="dirty"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKernelsResponseItemBuildMetadataBuilder(
            string version,
            string? commit,
            bool? dirty)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Commit = commit;
            this.Dirty = dirty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKernelsResponseItemBuildMetadataBuilder" /> class.
        /// </summary>
        public GetKernelsResponseItemBuildMetadataBuilder()
        {
        }

    }
}