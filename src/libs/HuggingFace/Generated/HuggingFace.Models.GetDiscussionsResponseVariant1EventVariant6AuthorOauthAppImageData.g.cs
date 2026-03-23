
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDiscussionsResponseVariant1EventVariant6AuthorOauthAppImageData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emoji")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Emoji { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colorFrom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColorFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colorTo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColorTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant1EventVariant6AuthorOauthAppImageData" /> class.
        /// </summary>
        /// <param name="emoji"></param>
        /// <param name="colorFrom"></param>
        /// <param name="colorTo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDiscussionsResponseVariant1EventVariant6AuthorOauthAppImageData(
            string emoji,
            string colorFrom,
            string colorTo)
        {
            this.Emoji = emoji ?? throw new global::System.ArgumentNullException(nameof(emoji));
            this.ColorFrom = colorFrom ?? throw new global::System.ArgumentNullException(nameof(colorFrom));
            this.ColorTo = colorTo ?? throw new global::System.ArgumentNullException(nameof(colorTo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant1EventVariant6AuthorOauthAppImageData" /> class.
        /// </summary>
        public GetDiscussionsResponseVariant1EventVariant6AuthorOauthAppImageData()
        {
        }
    }
}