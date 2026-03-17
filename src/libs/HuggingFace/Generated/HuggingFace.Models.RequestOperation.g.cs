
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.RequestOperationPathJsonConverter))]
        public global::HuggingFace.RequestOperationPath? Path { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="RequestOperation" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="path"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestOperation(
            string op,
            object value,
            global::HuggingFace.RequestOperationPath? path)
        {
            this.Op = op ?? throw new global::System.ArgumentNullException(nameof(op));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestOperation" /> class.
        /// </summary>
        public RequestOperation()
        {
        }
    }
}