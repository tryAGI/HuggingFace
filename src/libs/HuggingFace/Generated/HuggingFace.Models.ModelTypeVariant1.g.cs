
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelTypeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ClassifierModel Classifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTypeVariant1" /> class.
        /// </summary>
        /// <param name="classifier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelTypeVariant1(
            global::HuggingFace.ClassifierModel classifier)
        {
            this.Classifier = classifier ?? throw new global::System.ArgumentNullException(nameof(classifier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTypeVariant1" /> class.
        /// </summary>
        public ModelTypeVariant1()
        {
        }
    }
}