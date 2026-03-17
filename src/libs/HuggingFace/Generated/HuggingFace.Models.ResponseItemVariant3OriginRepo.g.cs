
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemVariant3OriginRepo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.ResponseItemVariant3OriginRepoAuthorVariant1, global::HuggingFace.ResponseItemVariant3OriginRepoAuthorVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.ResponseItemVariant3OriginRepoAuthorVariant1, global::HuggingFace.ResponseItemVariant3OriginRepoAuthorVariant2> Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant3OriginRepo" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemVariant3OriginRepo(
            global::HuggingFace.AnyOf<global::HuggingFace.ResponseItemVariant3OriginRepoAuthorVariant1, global::HuggingFace.ResponseItemVariant3OriginRepoAuthorVariant2> author,
            string name)
        {
            this.Author = author;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant3OriginRepo" /> class.
        /// </summary>
        public ResponseItemVariant3OriginRepo()
        {
        }
    }
}