
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseGatingVariant22
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"auto"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string Mode { get; set; } = "auto";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseGatingVariant22" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseGatingVariant22(
            string mode = "auto")
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseGatingVariant22" /> class.
        /// </summary>
        public ResponseGatingVariant22()
        {
        }
    }
}