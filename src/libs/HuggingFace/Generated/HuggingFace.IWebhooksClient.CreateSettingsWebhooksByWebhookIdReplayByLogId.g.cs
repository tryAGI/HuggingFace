#nullable enable

namespace HuggingFace
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Replay webhook log
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="logId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSettingsWebhooksReplayResponse> CreateSettingsWebhooksByWebhookIdReplayByLogIdAsync(
            string webhookId,
            string logId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}