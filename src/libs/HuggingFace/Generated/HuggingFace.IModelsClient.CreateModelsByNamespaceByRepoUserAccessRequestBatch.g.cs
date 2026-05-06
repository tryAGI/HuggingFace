#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Handle access requests in batch<br/>
        /// Accept or reject up to 100 access requests for a single gated repository in one call. The same `status` (and optional `rejectionReason`) is applied to every request in the list.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItem>> CreateModelsByNamespaceByRepoUserAccessRequestBatchAsync(
            string @namespace,
            string repo,

            global::HuggingFace.CreateModelsUserAccessRequestBatchRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Handle access requests in batch<br/>
        /// Accept or reject up to 100 access requests for a single gated repository in one call. The same `status` (and optional `rejectionReason`) is applied to every request in the list.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItem>>> CreateModelsByNamespaceByRepoUserAccessRequestBatchAsResponseAsync(
            string @namespace,
            string repo,

            global::HuggingFace.CreateModelsUserAccessRequestBatchRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Handle access requests in batch<br/>
        /// Accept or reject up to 100 access requests for a single gated repository in one call. The same `status` (and optional `rejectionReason`) is applied to every request in the list.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="status"></param>
        /// <param name="rejectionReason"></param>
        /// <param name="requests"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItem>> CreateModelsByNamespaceByRepoUserAccessRequestBatchAsync(
            string @namespace,
            string repo,
            global::HuggingFace.CreateModelsUserAccessRequestBatchRequestStatus status,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsUserAccessRequestBatchRequestRequest> requests,
            string? rejectionReason = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}