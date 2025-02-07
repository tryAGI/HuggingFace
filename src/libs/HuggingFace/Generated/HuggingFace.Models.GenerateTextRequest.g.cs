
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateTextRequest
    {
        /// <summary>
        /// The prompt that you want to complete.<br/>
        /// Example: This is a test.
        /// </summary>
        /// <example>This is a test.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::HuggingFace.GenerateTextRequestParameters? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::HuggingFace.GenerateTextRequestOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// The prompt that you want to complete.<br/>
        /// Example: This is a test.
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="options"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateTextRequest(
            string? inputs,
            global::HuggingFace.GenerateTextRequestParameters? parameters,
            global::HuggingFace.GenerateTextRequestOptions? options)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Parameters = parameters;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextRequest" /> class.
        /// </summary>
        public GenerateTextRequest()
        {
        }
    }
}