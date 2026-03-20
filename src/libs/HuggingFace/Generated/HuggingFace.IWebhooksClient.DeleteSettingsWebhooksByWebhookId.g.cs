#nullable enable

namespace HuggingFace
{
    public partial interface IWebhooksClient
    {

        /// <summary>
        /// Delete webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response6> DeleteSettingsWebhooksByWebhookIdAsync(
            string webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}