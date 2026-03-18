
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAICompatRequest
    {
        /// <summary>
        /// Default Value: null<br/>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Default Value: float
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.EncodingFormatJsonConverter))]
        public global::HuggingFace.EncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.InputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.Input Input { get; set; }

        /// <summary>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAICompatRequest" /> class.
        /// </summary>
        /// <param name="dimensions">
        /// Default Value: null<br/>
        /// Example: null
        /// </param>
        /// <param name="encodingFormat">
        /// Default Value: float
        /// </param>
        /// <param name="input"></param>
        /// <param name="model">
        /// Example: null
        /// </param>
        /// <param name="user">
        /// Example: null
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAICompatRequest(
            global::HuggingFace.Input input,
            int? dimensions,
            global::HuggingFace.EncodingFormat? encodingFormat,
            string? model,
            string? user)
        {
            this.Input = input;
            this.Dimensions = dimensions;
            this.EncodingFormat = encodingFormat;
            this.Model = model;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAICompatRequest" /> class.
        /// </summary>
        public OpenAICompatRequest()
        {
        }
    }
}