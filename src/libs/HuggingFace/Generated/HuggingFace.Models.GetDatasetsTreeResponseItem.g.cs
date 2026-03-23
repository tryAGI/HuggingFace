
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetsTreeResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetDatasetsTreeResponseItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDatasetsTreeResponseItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Oid { get; set; }

        /// <summary>
        /// If the file is a LFS pointer, it'll return the size of the remote file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lfs")]
        public global::HuggingFace.GetDatasetsTreeResponseItemLfs? Lfs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xetHash")]
        public string? XetHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastCommit")]
        public global::HuggingFace.GetDatasetsTreeResponseItemLastCommit? LastCommit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityFileStatus")]
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatus? SecurityFileStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetsTreeResponseItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="oid"></param>
        /// <param name="size">
        /// If the file is a LFS pointer, it'll return the size of the remote file
        /// </param>
        /// <param name="lfs"></param>
        /// <param name="xetHash"></param>
        /// <param name="lastCommit"></param>
        /// <param name="securityFileStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDatasetsTreeResponseItem(
            global::HuggingFace.GetDatasetsTreeResponseItemType type,
            string oid,
            int? size,
            global::HuggingFace.GetDatasetsTreeResponseItemLfs? lfs,
            string? xetHash,
            global::HuggingFace.GetDatasetsTreeResponseItemLastCommit? lastCommit,
            global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatus? securityFileStatus)
        {
            this.Type = type;
            this.Oid = oid ?? throw new global::System.ArgumentNullException(nameof(oid));
            this.Size = size;
            this.Lfs = lfs;
            this.XetHash = xetHash;
            this.LastCommit = lastCommit;
            this.SecurityFileStatus = securityFileStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetsTreeResponseItem" /> class.
        /// </summary>
        public GetDatasetsTreeResponseItem()
        {
        }
    }
}