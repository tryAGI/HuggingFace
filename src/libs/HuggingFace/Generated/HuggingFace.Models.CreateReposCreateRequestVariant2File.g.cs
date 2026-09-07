
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateReposCreateRequestVariant2File
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestVariant2FileEncodingJsonConverter))]
        public global::HuggingFace.CreateReposCreateRequestVariant2FileEncoding? Encoding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReposCreateRequestVariant2File" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateReposCreateRequestVariant2File(
            string content,
            string path,
            global::HuggingFace.CreateReposCreateRequestVariant2FileEncoding? encoding)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Encoding = encoding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReposCreateRequestVariant2File" /> class.
        /// </summary>
        public CreateReposCreateRequestVariant2File()
        {
        }

    }
}