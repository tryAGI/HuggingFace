
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItem10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pusher")]
        public global::HuggingFace.ResponseItemPusher2? Pusher { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileOid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileOid { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("pushedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PushedAt { get; set; }

        /// <summary>
        /// Potential filename of the LFS file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xetHash")]
        public string? XetHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem10" /> class.
        /// </summary>
        /// <param name="pusher"></param>
        /// <param name="ref"></param>
        /// <param name="fileOid"></param>
        /// <param name="oid"></param>
        /// <param name="size"></param>
        /// <param name="pushedAt"></param>
        /// <param name="filename">
        /// Potential filename of the LFS file
        /// </param>
        /// <param name="xetHash"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItem10(
            string fileOid,
            string oid,
            double size,
            global::System.DateTime pushedAt,
            global::HuggingFace.ResponseItemPusher2? pusher,
            string? @ref,
            string? filename,
            string? xetHash)
        {
            this.FileOid = fileOid ?? throw new global::System.ArgumentNullException(nameof(fileOid));
            this.Oid = oid ?? throw new global::System.ArgumentNullException(nameof(oid));
            this.Size = size;
            this.PushedAt = pushedAt;
            this.Pusher = pusher;
            this.Ref = @ref;
            this.Filename = filename;
            this.XetHash = xetHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem10" /> class.
        /// </summary>
        public ResponseItem10()
        {
        }
    }
}