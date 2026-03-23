
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePostsCommentResponseNewMessageAuthorOauthApp
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
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorOauthAppImageData? ImageData { get; set; }

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
        /// Initializes a new instance of the <see cref="CreatePostsCommentResponseNewMessageAuthorOauthApp" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="imageData"></param>
        /// <param name="url"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePostsCommentResponseNewMessageAuthorOauthApp(
            string name,
            string? imageUrl,
            global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorOauthAppImageData? imageData,
            string? url)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ImageUrl = imageUrl;
            this.ImageData = imageData;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePostsCommentResponseNewMessageAuthorOauthApp" /> class.
        /// </summary>
        public CreatePostsCommentResponseNewMessageAuthorOauthApp()
        {
        }
    }
}