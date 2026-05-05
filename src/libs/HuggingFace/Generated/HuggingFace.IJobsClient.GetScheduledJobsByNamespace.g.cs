#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// List scheduled jobs<br/>
        /// List scheduled jobs for an entity
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="label">
        /// Filter scheduled jobs by label. Format: 'key=value' (e.g., 'environment=production').
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetScheduledJobsResponseItem>> GetScheduledJobsByNamespaceAsync(
            string @namespace,
            string? label = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List scheduled jobs<br/>
        /// List scheduled jobs for an entity
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="label">
        /// Filter scheduled jobs by label. Format: 'key=value' (e.g., 'environment=production').
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetScheduledJobsResponseItem>>> GetScheduledJobsByNamespaceAsResponseAsync(
            string @namespace,
            string? label = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}