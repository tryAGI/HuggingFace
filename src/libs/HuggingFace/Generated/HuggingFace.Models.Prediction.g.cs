
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prediction
    {
        /// <summary>
        /// Example: admiration
        /// </summary>
        /// <example>admiration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prediction" /> class.
        /// </summary>
        /// <param name="label">
        /// Example: admiration
        /// </param>
        /// <param name="score">
        /// Example: 0.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Prediction(
            string label,
            float score)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prediction" /> class.
        /// </summary>
        public Prediction()
        {
        }
    }
}