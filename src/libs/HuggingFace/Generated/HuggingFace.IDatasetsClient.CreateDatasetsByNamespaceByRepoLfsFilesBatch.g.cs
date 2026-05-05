#nullable enable

namespace HuggingFace
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete Large files<br/>
        /// Delete Xet/LFS files in batch
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetsByNamespaceByRepoLfsFilesBatchAsync(
            string @namespace,
            string repo,

            global::HuggingFace.CreateDatasetsLfsFilesBatchRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Large files<br/>
        /// Delete Xet/LFS files in batch
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> CreateDatasetsByNamespaceByRepoLfsFilesBatchAsResponseAsync(
            string @namespace,
            string repo,

            global::HuggingFace.CreateDatasetsLfsFilesBatchRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Large files<br/>
        /// Delete Xet/LFS files in batch
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="deletions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetsByNamespaceByRepoLfsFilesBatchAsync(
            string @namespace,
            string repo,
            global::HuggingFace.CreateDatasetsLfsFilesBatchRequestDeletions deletions,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}