
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpacesPathsInfoResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateSpacesPathsInfoResponseItemType Type { get; set; }

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
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemLfs? Lfs { get; set; }

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
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemLastCommit? LastCommit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityFileStatus")]
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatus? SecurityFileStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpacesPathsInfoResponseItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="oid"></param>
        /// <param name="size"></param>
        /// <param name="path"></param>
        /// <param name="lfs"></param>
        /// <param name="xetHash"></param>
        /// <param name="lastCommit"></param>
        /// <param name="securityFileStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpacesPathsInfoResponseItem(
            global::HuggingFace.CreateSpacesPathsInfoResponseItemType type,
            string oid,
            double size,
            string path,
            global::HuggingFace.CreateSpacesPathsInfoResponseItemLfs? lfs,
            string? xetHash,
            global::HuggingFace.CreateSpacesPathsInfoResponseItemLastCommit? lastCommit,
            global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatus? securityFileStatus)
        {
            this.Type = type;
            this.Oid = oid ?? throw new global::System.ArgumentNullException(nameof(oid));
            this.Size = size;
            this.Lfs = lfs;
            this.XetHash = xetHash;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.LastCommit = lastCommit;
            this.SecurityFileStatus = securityFileStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpacesPathsInfoResponseItem" /> class.
        /// </summary>
        public CreateSpacesPathsInfoResponseItem()
        {
        }
    }
}