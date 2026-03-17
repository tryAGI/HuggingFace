
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompatGenerateRequest
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
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompatGenerateRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Example: My name is Olivier and I
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompatGenerateRequest(
            string inputs,
            global::HuggingFace.GenerateParameters? parameters,
            bool? stream)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Parameters = parameters;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompatGenerateRequest" /> class.
        /// </summary>
        public CompatGenerateRequest()
        {
        }
    }
}