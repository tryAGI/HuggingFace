
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response67
    {
        /// <summary>
        /// The normalized path of the subtree, starting with a slash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Total size in bytes of all files under the subtree
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response67" /> class.
        /// </summary>
        /// <param name="path">
        /// The normalized path of the subtree, starting with a slash
        /// </param>
        /// <param name="size">
        /// Total size in bytes of all files under the subtree
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response67(
            string path,
            int size)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response67" /> class.
        /// </summary>
        public Response67()
        {
        }
    }
}