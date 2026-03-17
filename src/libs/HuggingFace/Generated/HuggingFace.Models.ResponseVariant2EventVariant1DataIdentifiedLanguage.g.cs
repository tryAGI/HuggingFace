
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseVariant2EventVariant1DataIdentifiedLanguage
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
        /// Initializes a new instance of the <see cref="ResponseVariant2EventVariant1DataIdentifiedLanguage" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="probability"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseVariant2EventVariant1DataIdentifiedLanguage(
            string language,
            double probability)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Probability = probability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant2EventVariant1DataIdentifiedLanguage" /> class.
        /// </summary>
        public ResponseVariant2EventVariant1DataIdentifiedLanguage()
        {
        }
    }
}