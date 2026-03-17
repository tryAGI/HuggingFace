
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseNewStatus
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
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AllOfJsonConverter<global::HuggingFace.AnyOf<global::HuggingFace.ResponseNewStatusAuthorVariant1, global::HuggingFace.ResponseNewStatusAuthorVariant2>?, global::HuggingFace.ResponseNewStatusAuthor>))]
        public global::HuggingFace.AllOf<global::HuggingFace.AnyOf<global::HuggingFace.ResponseNewStatusAuthorVariant1, global::HuggingFace.ResponseNewStatusAuthorVariant2>?, global::HuggingFace.ResponseNewStatusAuthor>? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"status-change"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "status-change";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseNewStatusData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNewStatus" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="author"></param>
        /// <param name="type"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseNewStatus(
            string id,
            global::System.DateTime createdAt,
            global::HuggingFace.ResponseNewStatusData data,
            global::HuggingFace.AllOf<global::HuggingFace.AnyOf<global::HuggingFace.ResponseNewStatusAuthorVariant1, global::HuggingFace.ResponseNewStatusAuthorVariant2>?, global::HuggingFace.ResponseNewStatusAuthor>? author,
            string type = "status-change")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Author = author;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseNewStatus" /> class.
        /// </summary>
        public ResponseNewStatus()
        {
        }
    }
}