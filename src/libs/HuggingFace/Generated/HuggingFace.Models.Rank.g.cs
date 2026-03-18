
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Rank
    {
        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Example: 1.0
        /// </summary>
        /// <example>1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Score { get; set; }

        /// <summary>
        /// Default Value: null<br/>
        /// Example: Deep Learning is ...
        /// </summary>
        /// <example>Deep Learning is ...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Rank" /> class.
        /// </summary>
        /// <param name="index">
        /// Example: 0
        /// </param>
        /// <param name="score">
        /// Example: 1.0
        /// </param>
        /// <param name="text">
        /// Default Value: null<br/>
        /// Example: Deep Learning is ...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Rank(
            int index,
            float score,
            string? text)
        {
            this.Index = index;
            this.Score = score;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rank" /> class.
        /// </summary>
        public Rank()
        {
        }
    }
}