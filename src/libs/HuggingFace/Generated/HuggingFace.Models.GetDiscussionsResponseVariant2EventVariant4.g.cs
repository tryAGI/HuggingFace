
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDiscussionsResponseVariant2EventVariant4
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AllOfJsonConverter<global::HuggingFace.AnyOf<global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2>?, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4Author>))]
        public global::HuggingFace.AllOf<global::HuggingFace.AnyOf<global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2>?, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4Author>? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"title-change"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "title-change";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4Data Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant2EventVariant4" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="author"></param>
        /// <param name="type"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDiscussionsResponseVariant2EventVariant4(
            string id,
            global::System.DateTime createdAt,
            global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4Data data,
            global::HuggingFace.AllOf<global::HuggingFace.AnyOf<global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2>?, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4Author>? author,
            string type = "title-change")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Author = author;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant2EventVariant4" /> class.
        /// </summary>
        public GetDiscussionsResponseVariant2EventVariant4()
        {
        }
    }
}