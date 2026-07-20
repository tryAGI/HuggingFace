#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Update job exposed ports<br/>
        /// Replace the exposed ports of a running job, applied live (no re-run). Ports listed in `portsPublic` are reachable without any authentication.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PutJobsExposeResponse> PutJobsByNamespaceByJobIdExposeAsync(
            string @namespace,
            string jobId,

            global::HuggingFace.PutJobsExposeRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update job exposed ports<br/>
        /// Replace the exposed ports of a running job, applied live (no re-run). Ports listed in `portsPublic` are reachable without any authentication.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.PutJobsExposeResponse>> PutJobsByNamespaceByJobIdExposeAsResponseAsync(
            string @namespace,
            string jobId,

            global::HuggingFace.PutJobsExposeRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update job exposed ports<br/>
        /// Replace the exposed ports of a running job, applied live (no re-run). Ports listed in `portsPublic` are reachable without any authentication.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="ports"></param>
        /// <param name="portsPublic">
        /// Subset of `ports` reachable without any authentication.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PutJobsExposeResponse> PutJobsByNamespaceByJobIdExposeAsync(
            string @namespace,
            string jobId,
            global::System.Collections.Generic.IList<int> ports,
            global::System.Collections.Generic.IList<int>? portsPublic = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}