
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SparseValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseValue" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseValue(
            int index,
            float value)
        {
            this.Index = index;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseValue" /> class.
        /// </summary>
        public SparseValue()
        {
        }
    }
}