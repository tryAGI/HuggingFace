
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRequest
    {
        /// <summary>
        /// Example: My name is Olivier and I
        /// </summary>
        /// <example>My name is Olivier and I</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::HuggingFace.GenerateParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Example: My name is Olivier and I
        /// </param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRequest(
            string inputs,
            global::HuggingFace.GenerateParameters? parameters)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRequest" /> class.
        /// </summary>
        public GenerateRequest()
        {
        }
    }
}