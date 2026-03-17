
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseFilter
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
        [global::System.Text.Json.Serialization.JsonPropertyName("maxResults")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFilter" /> class.
        /// </summary>
        /// <param name="supported"></param>
        /// <param name="maxResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFilter(
            bool supported,
            double maxResults)
        {
            this.Supported = supported;
            this.MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFilter" /> class.
        /// </summary>
        public ResponseFilter()
        {
        }
    }
}