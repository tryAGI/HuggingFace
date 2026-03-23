#nullable enable

namespace HuggingFace
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetSettingsWebhooksResponse> GetSettingsWebhooksByWebhookIdAsync(
            string webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}