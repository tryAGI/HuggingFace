
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response88
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newTitle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseNewTitle NewTitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response88" /> class.
        /// </summary>
        /// <param name="newTitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response88(
            global::HuggingFace.ResponseNewTitle newTitle)
        {
            this.NewTitle = newTitle ?? throw new global::System.ArgumentNullException(nameof(newTitle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response88" /> class.
        /// </summary>
        public Response88()
        {
        }
    }
}