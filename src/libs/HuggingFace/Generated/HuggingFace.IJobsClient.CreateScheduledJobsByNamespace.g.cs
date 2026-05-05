#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Create a scheduled job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateScheduledJobsResponse> CreateScheduledJobsByNamespaceAsync(
            string @namespace,

            global::HuggingFace.CreateScheduledJobsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a scheduled job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateScheduledJobsResponse>> CreateScheduledJobsByNamespaceAsResponseAsync(
            string @namespace,

            global::HuggingFace.CreateScheduledJobsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a scheduled job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobSpec"></param>
        /// <param name="schedule">
        /// CRON schedule expression (e.g., '0 9 * * 1' for 9 AM every Monday).
        /// </param>
        /// <param name="suspend">
        /// Whether the scheduled job is suspended (paused)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="concurrency">
        /// Whether multiple instances of this job can run concurrently<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateScheduledJobsResponse> CreateScheduledJobsByNamespaceAsync(
            string @namespace,
            global::HuggingFace.CreateScheduledJobsRequestJobSpec jobSpec,
            string schedule,
            bool? suspend = default,
            bool? concurrency = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}