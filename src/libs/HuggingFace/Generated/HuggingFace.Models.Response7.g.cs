
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response7
    {
        /// <summary>
        /// Webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseWebhook4 Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response7" /> class.
        /// </summary>
        /// <param name="webhook">
        /// Webhook
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response7(
            global::HuggingFace.ResponseWebhook4 webhook)
        {
            this.Webhook = webhook ?? throw new global::System.ArgumentNullException(nameof(webhook));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response7" /> class.
        /// </summary>
        public Response7()
        {
        }
    }
}