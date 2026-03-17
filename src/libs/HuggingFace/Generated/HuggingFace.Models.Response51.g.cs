
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response51
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newMessage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseNewMessage3 NewMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response51" /> class.
        /// </summary>
        /// <param name="newMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response51(
            global::HuggingFace.ResponseNewMessage3 newMessage)
        {
            this.NewMessage = newMessage ?? throw new global::System.ArgumentNullException(nameof(newMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response51" /> class.
        /// </summary>
        public Response51()
        {
        }
    }
}