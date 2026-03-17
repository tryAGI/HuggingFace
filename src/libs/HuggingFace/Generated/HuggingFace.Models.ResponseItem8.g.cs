
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItem8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_vectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemVectors Vectors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heading1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Heading1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Product { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_page_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourcePageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_page_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourcePageTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heading2")]
        public string? Heading2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heading3")]
        public string? Heading3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heading4")]
        public string? Heading4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heading5")]
        public string? Heading5 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem8" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="vectors"></param>
        /// <param name="heading1"></param>
        /// <param name="text"></param>
        /// <param name="product"></param>
        /// <param name="sourcePageUrl"></param>
        /// <param name="sourcePageTitle"></param>
        /// <param name="heading2"></param>
        /// <param name="heading3"></param>
        /// <param name="heading4"></param>
        /// <param name="heading5"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItem8(
            string id,
            global::HuggingFace.ResponseItemVectors vectors,
            string heading1,
            string text,
            string product,
            string sourcePageUrl,
            string sourcePageTitle,
            string? heading2,
            string? heading3,
            string? heading4,
            string? heading5)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Vectors = vectors ?? throw new global::System.ArgumentNullException(nameof(vectors));
            this.Heading1 = heading1 ?? throw new global::System.ArgumentNullException(nameof(heading1));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
            this.SourcePageUrl = sourcePageUrl ?? throw new global::System.ArgumentNullException(nameof(sourcePageUrl));
            this.SourcePageTitle = sourcePageTitle ?? throw new global::System.ArgumentNullException(nameof(sourcePageTitle));
            this.Heading2 = heading2;
            this.Heading3 = heading3;
            this.Heading4 = heading4;
            this.Heading5 = heading5;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem8" /> class.
        /// </summary>
        public ResponseItem8()
        {
        }
    }
}