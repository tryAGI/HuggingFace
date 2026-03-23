
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateReposCreateRequestFile
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestFileEncodingJsonConverter))]
        public global::HuggingFace.CreateReposCreateRequestFileEncoding? Encoding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReposCreateRequestFile" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateReposCreateRequestFile(
            string content,
            string path,
            global::HuggingFace.CreateReposCreateRequestFileEncoding? encoding)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Encoding = encoding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReposCreateRequestFile" /> class.
        /// </summary>
        public CreateReposCreateRequestFile()
        {
        }
    }
}