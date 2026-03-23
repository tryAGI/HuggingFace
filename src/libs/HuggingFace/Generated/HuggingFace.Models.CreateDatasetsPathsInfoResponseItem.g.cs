
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetsPathsInfoResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateDatasetsPathsInfoResponseItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateDatasetsPathsInfoResponseItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Oid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lfs")]
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemLfs? Lfs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xetHash")]
        public string? XetHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastCommit")]
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemLastCommit? LastCommit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityFileStatus")]
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatus? SecurityFileStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetsPathsInfoResponseItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="oid"></param>
        /// <param name="size"></param>
        /// <param name="lfs"></param>
        /// <param name="xetHash"></param>
        /// <param name="path"></param>
        /// <param name="lastCommit"></param>
        /// <param name="securityFileStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetsPathsInfoResponseItem(
            global::HuggingFace.CreateDatasetsPathsInfoResponseItemType type,
            string oid,
            double size,
            string path,
            global::HuggingFace.CreateDatasetsPathsInfoResponseItemLfs? lfs,
            string? xetHash,
            global::HuggingFace.CreateDatasetsPathsInfoResponseItemLastCommit? lastCommit,
            global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatus? securityFileStatus)
        {
            this.Type = type;
            this.Oid = oid ?? throw new global::System.ArgumentNullException(nameof(oid));
            this.Size = size;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Lfs = lfs;
            this.XetHash = xetHash;
            this.LastCommit = lastCommit;
            this.SecurityFileStatus = securityFileStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetsPathsInfoResponseItem" /> class.
        /// </summary>
        public CreateDatasetsPathsInfoResponseItem()
        {
        }
    }
}