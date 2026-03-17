
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsePaper2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsePaper2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="id"></param>
        /// <param name="private"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsePaper2(
            string id,
            string id,
            bool? @private)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Private = @private;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsePaper2" /> class.
        /// </summary>
        public ResponsePaper2()
        {
        }
    }
}