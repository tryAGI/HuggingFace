
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrefillToken
    {
        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: -0.34F
        /// </summary>
        /// <example>-0.34F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        public float? Logprob { get; set; }

        /// <summary>
        /// Example: test
        /// </summary>
        /// <example>test</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrefillToken" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 0
        /// </param>
        /// <param name="logprob">
        /// Example: -0.34F
        /// </param>
        /// <param name="text">
        /// Example: test
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrefillToken(
            int id,
            string text,
            float? logprob)
        {
            this.Id = id;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Logprob = logprob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrefillToken" /> class.
        /// </summary>
        public PrefillToken()
        {
        }
    }
}