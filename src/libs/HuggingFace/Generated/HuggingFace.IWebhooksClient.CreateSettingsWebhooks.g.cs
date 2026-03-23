#nullable enable

namespace HuggingFace
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create webhook
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSettingsWebhooksResponse> CreateSettingsWebhooksAsync(

            global::HuggingFace.CreateSettingsWebhooksRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create webhook
        /// </summary>
        /// <param name="watched"></param>
        /// <param name="url"></param>
        /// <param name="job"></param>
        /// <param name="jobSourceId"></param>
        /// <param name="domains"></param>
        /// <param name="secret"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSettingsWebhooksResponse> CreateSettingsWebhooksAsync(
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem> watched,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestDomain> domains,
            string? url = default,
            global::HuggingFace.CreateSettingsWebhooksRequestJob? job = default,
            string? jobSourceId = default,
            string? secret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}