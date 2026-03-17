
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response87
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newStatus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseNewStatus NewStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response87" /> class.
        /// </summary>
        /// <param name="newStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response87(
            global::HuggingFace.ResponseNewStatus newStatus)
        {
            this.NewStatus = newStatus ?? throw new global::System.ArgumentNullException(nameof(newStatus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response87" /> class.
        /// </summary>
        public Response87()
        {
        }
    }
}