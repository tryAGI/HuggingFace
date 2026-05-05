#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Update job labels<br/>
        /// Replace user-provided labels on a job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PutJobsLabelsResponse> PutJobsByNamespaceByJobIdLabelsAsync(
            string @namespace,
            string jobId,

            global::HuggingFace.PutJobsLabelsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update job labels<br/>
        /// Replace user-provided labels on a job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.PutJobsLabelsResponse>> PutJobsByNamespaceByJobIdLabelsAsResponseAsync(
            string @namespace,
            string jobId,

            global::HuggingFace.PutJobsLabelsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update job labels<br/>
        /// Replace user-provided labels on a job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="labels">
        /// The new labels to set on the job. Replaces all existing labels.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PutJobsLabelsResponse> PutJobsByNamespaceByJobIdLabelsAsync(
            string @namespace,
            string jobId,
            global::System.Collections.Generic.Dictionary<string, string> labels,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}