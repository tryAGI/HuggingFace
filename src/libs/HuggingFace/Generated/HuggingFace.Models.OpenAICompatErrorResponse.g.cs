
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAICompatErrorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ErrorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ErrorType ErrorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAICompatErrorResponse" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="errorType"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAICompatErrorResponse(
            int code,
            global::HuggingFace.ErrorType errorType,
            string message)
        {
            this.Code = code;
            this.ErrorType = errorType;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAICompatErrorResponse" /> class.
        /// </summary>
        public OpenAICompatErrorResponse()
        {
        }
    }
}