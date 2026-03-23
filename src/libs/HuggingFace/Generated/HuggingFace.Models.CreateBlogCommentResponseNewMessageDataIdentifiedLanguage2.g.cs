
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBlogCommentResponseNewMessageDataIdentifiedLanguage2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Probability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBlogCommentResponseNewMessageDataIdentifiedLanguage2" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="probability"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBlogCommentResponseNewMessageDataIdentifiedLanguage2(
            string language,
            double probability)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Probability = probability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBlogCommentResponseNewMessageDataIdentifiedLanguage2" /> class.
        /// </summary>
        public CreateBlogCommentResponseNewMessageDataIdentifiedLanguage2()
        {
        }
    }
}