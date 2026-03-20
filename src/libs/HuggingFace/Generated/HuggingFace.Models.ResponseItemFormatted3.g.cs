
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Available if expand includes formatted
    /// </summary>
    public sealed partial class ResponseItemFormatted3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemFormatted3" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemFormatted3(
            string title,
            string? message)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemFormatted3" /> class.
        /// </summary>
        public ResponseItemFormatted3()
        {
        }
    }
}