
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ok")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ok { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimedPaperId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClaimedPaperId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response9" /> class.
        /// </summary>
        /// <param name="ok"></param>
        /// <param name="claimedPaperId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response9(
            bool ok,
            string claimedPaperId)
        {
            this.Ok = ok;
            this.ClaimedPaperId = claimedPaperId ?? throw new global::System.ArgumentNullException(nameof(claimedPaperId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response9" /> class.
        /// </summary>
        public Response9()
        {
        }
    }
}