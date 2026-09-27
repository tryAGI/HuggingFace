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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSettingsWebhooksResponse2> CreateSettingsWebhooksByWebhookIdAsync(
            string webhookId,

            global::HuggingFace.CreateSettingsWebhooksRequest2 request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateSettingsWebhooksResponse2>> CreateSettingsWebhooksByWebhookIdAsResponseAsync(
            string webhookId,

            global::HuggingFace.CreateSettingsWebhooksRequest2 request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="watched"></param>
        /// <param name="url"></param>
        /// <param name="job"></param>
        /// <param name="jobSourceId"></param>
        /// <param name="secrets">
        /// Secrets of the job started by the webhook, used together with `jobSourceId`: the source job's own secrets are never copied. On update, listed keys are replaced, an empty value removes a secret, and omitted keys keep their stored value.
        /// </param>
        /// <param name="domains"></param>
        /// <param name="secret"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSettingsWebhooksResponse2> CreateSettingsWebhooksByWebhookIdAsync(
            string webhookId,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem2> watched,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestDomain2> domains,
            string? url = default,
            global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant12, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant22>? job = default,
            string? jobSourceId = default,
            global::System.Collections.Generic.Dictionary<string, string>? secrets = default,
            string? secret = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}