
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DecodeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.InputIdsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.InputIds Ids { get; set; }

        /// <summary>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_special_tokens")]
        public bool? SkipSpecialTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeRequest" /> class.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="skipSpecialTokens">
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecodeRequest(
            global::HuggingFace.InputIds ids,
            bool? skipSpecialTokens)
        {
            this.Ids = ids;
            this.SkipSpecialTokens = skipSpecialTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeRequest" /> class.
        /// </summary>
        public DecodeRequest()
        {
        }
    }
}