
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response148
    {
        /// <summary>
        /// The XET hash of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hash { get; set; }

        /// <summary>
        /// The XET auth URL for the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefreshUrl { get; set; }

        /// <summary>
        /// The XET reconstruction URL for the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reconstructionUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReconstructionUrl { get; set; }

        /// <summary>
        /// The ETag of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Etag { get; set; }

        /// <summary>
        /// The size of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response148" /> class.
        /// </summary>
        /// <param name="hash">
        /// The XET hash of the file
        /// </param>
        /// <param name="refreshUrl">
        /// The XET auth URL for the file
        /// </param>
        /// <param name="reconstructionUrl">
        /// The XET reconstruction URL for the file
        /// </param>
        /// <param name="etag">
        /// The ETag of the file
        /// </param>
        /// <param name="size">
        /// The size of the file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response148(
            string hash,
            string refreshUrl,
            string reconstructionUrl,
            string etag,
            double size)
        {
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
            this.RefreshUrl = refreshUrl ?? throw new global::System.ArgumentNullException(nameof(refreshUrl));
            this.ReconstructionUrl = reconstructionUrl ?? throw new global::System.ArgumentNullException(nameof(reconstructionUrl));
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response148" /> class.
        /// </summary>
        public Response148()
        {
        }
    }
}