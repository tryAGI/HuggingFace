#nullable enable

namespace HuggingFace
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetSettingsWebhooksResponse> GetSettingsWebhooksByWebhookIdAsync(
            string webhookId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetSettingsWebhooksResponse>> GetSettingsWebhooksByWebhookIdAsResponseAsync(
            string webhookId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}