
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePapersMediaRequest
    {
        /// <summary>
        /// Media URLs, in display order
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaUrls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MediaUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePapersMediaRequest" /> class.
        /// </summary>
        /// <param name="mediaUrls">
        /// Media URLs, in display order
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePapersMediaRequest(
            global::System.Collections.Generic.IList<string> mediaUrls)
        {
            this.MediaUrls = mediaUrls ?? throw new global::System.ArgumentNullException(nameof(mediaUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePapersMediaRequest" /> class.
        /// </summary>
        public CreatePapersMediaRequest()
        {
        }

    }
}