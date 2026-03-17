
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItem12
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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemAuthor2> Authors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// Available if expand includes formatted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatted")]
        public global::HuggingFace.ResponseItemFormatted? Formatted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem12" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="authors"></param>
        /// <param name="date"></param>
        /// <param name="formatted">
        /// Available if expand includes formatted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItem12(
            string id,
            string title,
            string message,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemAuthor2> authors,
            global::System.DateTime date,
            global::HuggingFace.ResponseItemFormatted? formatted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Authors = authors ?? throw new global::System.ArgumentNullException(nameof(authors));
            this.Date = date;
            this.Formatted = formatted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem12" /> class.
        /// </summary>
        public ResponseItem12()
        {
        }
    }
}