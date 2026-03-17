
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseSocialHandles2
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSocialHandles2" /> class.
        /// </summary>
        /// <param name="twitter"></param>
        /// <param name="github"></param>
        /// <param name="linkedin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSocialHandles2(
            string? twitter,
            string? github,
            string? linkedin)
        {
            this.Twitter = twitter;
            this.Github = github;
            this.Linkedin = linkedin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSocialHandles2" /> class.
        /// </summary>
        public ResponseSocialHandles2()
        {
        }
    }
}