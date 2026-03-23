
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSpacesTreeResponseItemLfs
    {
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
        public required int Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pointerSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PointerSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesTreeResponseItemLfs" /> class.
        /// </summary>
        /// <param name="oid"></param>
        /// <param name="size"></param>
        /// <param name="pointerSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSpacesTreeResponseItemLfs(
            string oid,
            int size,
            int pointerSize)
        {
            this.Oid = oid ?? throw new global::System.ArgumentNullException(nameof(oid));
            this.Size = size;
            this.PointerSize = pointerSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesTreeResponseItemLfs" /> class.
        /// </summary>
        public GetSpacesTreeResponseItemLfs()
        {
        }
    }
}