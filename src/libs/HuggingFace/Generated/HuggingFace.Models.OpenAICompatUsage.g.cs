
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAICompatUsage
    {
        /// <summary>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAICompatUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Example: 512
        /// </param>
        /// <param name="totalTokens">
        /// Example: 512
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAICompatUsage(
            int promptTokens,
            int totalTokens)
        {
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAICompatUsage" /> class.
        /// </summary>
        public OpenAICompatUsage()
        {
        }
    }
}