
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPapersResponseLinkedSpace
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
        [global::System.Text.Json.Serialization.JsonPropertyName("emoji")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Emoji { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Running { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shortDescription")]
        public string? ShortDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Featured { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPapersResponseLinkedSpace" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="emoji"></param>
        /// <param name="running"></param>
        /// <param name="featured"></param>
        /// <param name="shortDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPapersResponseLinkedSpace(
            string id,
            string emoji,
            bool running,
            bool featured,
            string? shortDescription)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Emoji = emoji ?? throw new global::System.ArgumentNullException(nameof(emoji));
            this.Running = running;
            this.ShortDescription = shortDescription;
            this.Featured = featured;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPapersResponseLinkedSpace" /> class.
        /// </summary>
        public GetPapersResponseLinkedSpace()
        {
        }

    }
}