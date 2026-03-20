
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItem20
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemType8JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemType8 Type { get; set; }

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
        public global::HuggingFace.ResponseItemLfs6? Lfs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xetHash")]
        public string? XetHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastCommit")]
        public global::HuggingFace.ResponseItemLastCommit6? LastCommit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityFileStatus")]
        public global::HuggingFace.ResponseItemSecurityFileStatus6? SecurityFileStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem20" /> class.
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
        public ResponseItem20(
            global::HuggingFace.ResponseItemType8 type,
            string oid,
            int? size,
            global::HuggingFace.ResponseItemLfs6? lfs,
            string? xetHash,
            global::HuggingFace.ResponseItemLastCommit6? lastCommit,
            global::HuggingFace.ResponseItemSecurityFileStatus6? securityFileStatus)
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
        /// Initializes a new instance of the <see cref="ResponseItem20" /> class.
        /// </summary>
        public ResponseItem20()
        {
        }
    }
}