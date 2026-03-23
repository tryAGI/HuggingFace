#nullable enable

namespace HuggingFace
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Enable/disable webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="action"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSettingsWebhooksResponse3> CreateSettingsWebhooksByWebhookIdByActionAsync(
            string webhookId,
            global::HuggingFace.CreateSettingsWebhooksAction action,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}