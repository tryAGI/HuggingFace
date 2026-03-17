
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseBulk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxOperations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxOperations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxPayloadSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxPayloadSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBulk" /> class.
        /// </summary>
        /// <param name="supported"></param>
        /// <param name="maxOperations"></param>
        /// <param name="maxPayloadSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseBulk(
            bool supported,
            double maxOperations,
            double maxPayloadSize)
        {
            this.Supported = supported;
            this.MaxOperations = maxOperations;
            this.MaxPayloadSize = maxPayloadSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBulk" /> class.
        /// </summary>
        public ResponseBulk()
        {
        }
    }
}