
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateQuicksearchResponseContainer
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
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Whether the repo is owned by a user or an organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateQuicksearchResponseContainerAuthorTypeJsonConverter))]
        public global::HuggingFace.CreateQuicksearchResponseContainerAuthorType? AuthorType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateQuicksearchResponseContainer" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="private"></param>
        /// <param name="authorType">
        /// Whether the repo is owned by a user or an organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateQuicksearchResponseContainer(
            string id,
            bool? @private,
            global::HuggingFace.CreateQuicksearchResponseContainerAuthorType? authorType)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Private = @private;
            this.AuthorType = authorType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateQuicksearchResponseContainer" /> class.
        /// </summary>
        public CreateQuicksearchResponseContainer()
        {
        }

    }
}