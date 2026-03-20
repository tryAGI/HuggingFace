#nullable enable

namespace HuggingFace
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Update webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response5> CreateSettingsWebhooksByWebhookIdAsync(
            string webhookId,

            global::HuggingFace.Request5 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="watched"></param>
        /// <param name="url"></param>
        /// <param name="job"></param>
        /// <param name="jobSourceId"></param>
        /// <param name="domains"></param>
        /// <param name="secret"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response5> CreateSettingsWebhooksByWebhookIdAsync(
            string webhookId,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestWatchedItem2> watched,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestDomain2> domains,
            string? url = default,
            global::HuggingFace.RequestJob2? job = default,
            string? jobSourceId = default,
            string? secret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}