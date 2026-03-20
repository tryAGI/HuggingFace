
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseVariant23
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"True"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("notInCache")]
        public string NotInCache { get; set; } = "True";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant23" /> class.
        /// </summary>
        /// <param name="notInCache"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseVariant23(
            string notInCache = "True")
        {
            this.NotInCache = notInCache;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant23" /> class.
        /// </summary>
        public ResponseVariant23()
        {
        }
    }
}