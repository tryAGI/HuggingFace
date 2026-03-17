
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseNewMessageDataLatest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Raw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Html { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.ResponseNewMessageDataLatestAuthorVariant1, global::HuggingFace.ResponseNewMessageDataLatestAuthorVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.ResponseNewMessageDataLatestAuthorVariant1, global::HuggingFace.ResponseNewMessageDataLatestAuthorVariant2>? Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNewMessageDataLatest" /> class.
        /// </summary>
        /// <param name="raw"></param>
        /// <param name="html"></param>
        /// <param name="updatedAt"></param>
        /// <param name="author"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseNewMessageDataLatest(
            string raw,
            string html,
            global::System.DateTime updatedAt,
            global::HuggingFace.AnyOf<global::HuggingFace.ResponseNewMessageDataLatestAuthorVariant1, global::HuggingFace.ResponseNewMessageDataLatestAuthorVariant2>? author)
        {
            this.Raw = raw ?? throw new global::System.ArgumentNullException(nameof(raw));
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.UpdatedAt = updatedAt;
            this.Author = author;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNewMessageDataLatest" /> class.
        /// </summary>
        public ResponseNewMessageDataLatest()
        {
        }
    }
}