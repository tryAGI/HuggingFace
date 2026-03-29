
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GrammarTypeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant1TypeJsonConverter))]
        public global::HuggingFace.GrammarTypeVariant1Type Type { get; set; }

        /// <summary>
        /// A string that represents a [JSON Schema](https://json-schema.org/).<br/>
        /// JSON Schema is a declarative language that allows to annotate JSON documents<br/>
        /// with types and descriptions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GrammarTypeVariant1" /> class.
        /// </summary>
        /// <param name="value">
        /// A string that represents a [JSON Schema](https://json-schema.org/).<br/>
        /// JSON Schema is a declarative language that allows to annotate JSON documents<br/>
        /// with types and descriptions.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GrammarTypeVariant1(
            object value,
            global::HuggingFace.GrammarTypeVariant1Type type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrammarTypeVariant1" /> class.
        /// </summary>
        public GrammarTypeVariant1()
        {
        }
    }
}