
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseResource2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseResourceSchema2> Schemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::HuggingFace.ResponseResourceMember>? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseResourceMeta2 Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseResource2" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="members"></param>
        /// <param name="externalId"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseResource2(
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseResourceSchema2> schemas,
            string id,
            string displayName,
            global::HuggingFace.ResponseResourceMeta2 meta,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseResourceMember>? members,
            string? externalId)
        {
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Members = members;
            this.ExternalId = externalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseResource2" /> class.
        /// </summary>
        public ResponseResource2()
        {
        }
    }
}