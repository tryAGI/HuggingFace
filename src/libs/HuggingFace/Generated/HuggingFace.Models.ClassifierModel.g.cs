
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifierModel
    {
        /// <summary>
        /// Example: {"0":"LABEL"}
        /// </summary>
        /// <example>{"0":"LABEL"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id2label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Id2label { get; set; }

        /// <summary>
        /// Example: {"LABEL":0}
        /// </summary>
        /// <example>{"LABEL":0}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label2id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> Label2id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierModel" /> class.
        /// </summary>
        /// <param name="id2label">
        /// Example: {"0":"LABEL"}
        /// </param>
        /// <param name="label2id">
        /// Example: {"LABEL":0}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierModel(
            global::System.Collections.Generic.Dictionary<string, string> id2label,
            global::System.Collections.Generic.Dictionary<string, int> label2id)
        {
            this.Id2label = id2label ?? throw new global::System.ArgumentNullException(nameof(id2label));
            this.Label2id = label2id ?? throw new global::System.ArgumentNullException(nameof(label2id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierModel" /> class.
        /// </summary>
        public ClassifierModel()
        {
        }
    }
}