
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSettingsWebhooksResponse3
    {
        /// <summary>
        /// Webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateSettingsWebhooksResponseWebhook3 Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksResponse3" /> class.
        /// </summary>
        /// <param name="webhook">
        /// Webhook
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsWebhooksResponse3(
            global::HuggingFace.CreateSettingsWebhooksResponseWebhook3 webhook)
        {
            this.Webhook = webhook ?? throw new global::System.ArgumentNullException(nameof(webhook));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksResponse3" /> class.
        /// </summary>
        public CreateSettingsWebhooksResponse3()
        {
        }
    }
}