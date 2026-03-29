
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::HuggingFace.Details? Details { get; set; }

        /// <summary>
        /// Example: test
        /// </summary>
        /// <example>test</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GeneratedText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateResponse" /> class.
        /// </summary>
        /// <param name="generatedText">
        /// Example: test
        /// </param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateResponse(
            string generatedText,
            global::HuggingFace.Details? details)
        {
            this.Details = details;
            this.GeneratedText = generatedText ?? throw new global::System.ArgumentNullException(nameof(generatedText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateResponse" /> class.
        /// </summary>
        public GenerateResponse()
        {
        }
    }
}