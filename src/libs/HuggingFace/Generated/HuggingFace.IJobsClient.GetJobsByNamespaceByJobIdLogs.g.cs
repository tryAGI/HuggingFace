#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Stream job logs<br/>
        /// Stream the logs of a job, using SSE
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="tail">
        /// Maximum number of lines to return from the logs.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetJobsByNamespaceByJobIdLogsAsync(
            string @namespace,
            string jobId,
            int? tail = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream job logs<br/>
        /// Stream the logs of a job, using SSE
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="tail">
        /// Maximum number of lines to return from the logs.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> GetJobsByNamespaceByJobIdLogsAsResponseAsync(
            string @namespace,
            string jobId,
            int? tail = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}