
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDiscussionsStatusResponseNewStatus
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AllOfJsonConverter<global::HuggingFace.AnyOf<global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant1, global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2>?, global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthor>))]
        public global::HuggingFace.AllOf<global::HuggingFace.AnyOf<global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant1, global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2>?, global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthor>? Author { get; set; }

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
        public required global::HuggingFace.CreateDiscussionsStatusResponseNewStatusData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsStatusResponseNewStatus" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="data"></param>
        /// <param name="author"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDiscussionsStatusResponseNewStatus(
            string id,
            global::System.DateTime createdAt,
            global::HuggingFace.CreateDiscussionsStatusResponseNewStatusData data,
            global::HuggingFace.AllOf<global::HuggingFace.AnyOf<global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant1, global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2>?, global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthor>? author,
            string type = "status-change")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Author = author;
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsStatusResponseNewStatus" /> class.
        /// </summary>
        public CreateDiscussionsStatusResponseNewStatus()
        {
        }
    }
}