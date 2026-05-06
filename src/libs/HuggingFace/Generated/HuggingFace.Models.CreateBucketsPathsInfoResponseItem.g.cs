
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBucketsPathsInfoResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateBucketsPathsInfoResponseItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateBucketsPathsInfoResponseItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Not defined for directories
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xetHash")]
        public string? XetHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mtime")]
        public global::System.DateTime? Mtime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UploadedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBucketsPathsInfoResponseItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="path"></param>
        /// <param name="uploadedAt"></param>
        /// <param name="size"></param>
        /// <param name="xetHash">
        /// Not defined for directories
        /// </param>
        /// <param name="mtime"></param>
        /// <param name="contentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBucketsPathsInfoResponseItem(
            global::HuggingFace.CreateBucketsPathsInfoResponseItemType type,
            string path,
            global::System.DateTime uploadedAt,
            int? size,
            string? xetHash,
            global::System.DateTime? mtime,
            string? contentType)
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Size = size;
            this.XetHash = xetHash;
            this.Mtime = mtime;
            this.UploadedAt = uploadedAt;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBucketsPathsInfoResponseItem" /> class.
        /// </summary>
        public CreateBucketsPathsInfoResponseItem()
        {
        }
    }
}