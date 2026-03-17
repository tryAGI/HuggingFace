
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseSocialHandles
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter")]
        public string? Twitter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github")]
        public string? Github { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedin")]
        public string? Linkedin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bluesky")]
        public string? Bluesky { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSocialHandles" /> class.
        /// </summary>
        /// <param name="twitter"></param>
        /// <param name="github"></param>
        /// <param name="linkedin"></param>
        /// <param name="bluesky"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSocialHandles(
            string? twitter,
            string? github,
            string? linkedin,
            string? bluesky)
        {
            this.Twitter = twitter;
            this.Github = github;
            this.Linkedin = linkedin;
            this.Bluesky = bluesky;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSocialHandles" /> class.
        /// </summary>
        public ResponseSocialHandles()
        {
        }
    }
}