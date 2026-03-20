
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItem23
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemType10JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemType10 Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subType")]
        public string? SubType { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clickable")]
        public bool? Clickable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem23" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="label"></param>
        /// <param name="type"></param>
        /// <param name="subType"></param>
        /// <param name="clickable">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItem23(
            string id,
            string label,
            global::HuggingFace.ResponseItemType10 type,
            string? subType,
            bool? clickable)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Type = type;
            this.SubType = subType;
            this.Clickable = clickable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem23" /> class.
        /// </summary>
        public ResponseItem23()
        {
        }
    }
}