#nullable enable

namespace HuggingFace
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Delete webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.DeleteSettingsWebhooksResponse> DeleteSettingsWebhooksByWebhookIdAsync(
            string webhookId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.DeleteSettingsWebhooksResponse>> DeleteSettingsWebhooksByWebhookIdAsResponseAsync(
            string webhookId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}