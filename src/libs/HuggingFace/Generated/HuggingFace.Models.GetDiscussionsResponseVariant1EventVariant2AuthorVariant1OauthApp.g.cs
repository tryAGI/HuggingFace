
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDiscussionsResponseVariant1EventVariant2AuthorVariant1OauthApp
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageData")]
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant1OauthAppImageData? ImageData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

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
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant1EventVariant2AuthorVariant1OauthApp" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="imageUrl"></param>
        /// <param name="imageData"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDiscussionsResponseVariant1EventVariant2AuthorVariant1OauthApp(
            string name,
            string? imageUrl,
            global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant1OauthAppImageData? imageData,
            string? url)
        {
            this.ImageUrl = imageUrl;
            this.ImageData = imageData;
            this.Url = url;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant1EventVariant2AuthorVariant1OauthApp" /> class.
        /// </summary>
        public GetDiscussionsResponseVariant1EventVariant2AuthorVariant1OauthApp()
        {
        }

    }
}