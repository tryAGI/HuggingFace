
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response53
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseHit> Hits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response53" /> class.
        /// </summary>
        /// <param name="hits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response53(
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseHit> hits)
        {
            this.Hits = hits ?? throw new global::System.ArgumentNullException(nameof(hits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response53" /> class.
        /// </summary>
        public Response53()
        {
        }
    }
}