
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCollectionsResponseItemVariant3RuntimeVolume
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateCollectionsResponseItemVariant3RuntimeVolumeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeVolumeType Type { get; set; }

        /// <summary>
        /// Source identifier, e.g. 'username/my-bucket' or 'username/my-model'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Mount path inside the container, e.g. '/data'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mountPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountPath { get; set; }

        /// <summary>
        /// Git revision (only for repos, defaults to 'main')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public string? Revision { get; set; }

        /// <summary>
        /// Read-only mount (forced true for repos, defaults to false for buckets)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readOnly")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Subfolder prefix inside the bucket/repo to mount, e.g. 'path/to/dir'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResponseItemVariant3RuntimeVolume" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="source">
        /// Source identifier, e.g. 'username/my-bucket' or 'username/my-model'
        /// </param>
        /// <param name="mountPath">
        /// Mount path inside the container, e.g. '/data'
        /// </param>
        /// <param name="revision">
        /// Git revision (only for repos, defaults to 'main')
        /// </param>
        /// <param name="readOnly">
        /// Read-only mount (forced true for repos, defaults to false for buckets)
        /// </param>
        /// <param name="path">
        /// Subfolder prefix inside the bucket/repo to mount, e.g. 'path/to/dir'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsResponseItemVariant3RuntimeVolume(
            global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeVolumeType type,
            string source,
            string mountPath,
            string? revision,
            bool? readOnly,
            string? path)
        {
            this.Type = type;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
            this.Revision = revision;
            this.ReadOnly = readOnly;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResponseItemVariant3RuntimeVolume" /> class.
        /// </summary>
        public CreateCollectionsResponseItemVariant3RuntimeVolume()
        {
        }
    }
}