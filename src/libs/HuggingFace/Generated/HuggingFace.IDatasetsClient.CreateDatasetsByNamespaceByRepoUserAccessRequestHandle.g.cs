#nullable enable

namespace HuggingFace
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Handle access request<br/>
        /// Handle a user's access request to a gated repository
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetsByNamespaceByRepoUserAccessRequestHandleAsync(
            string @namespace,
            string repo,

            global::HuggingFace.OneOf<global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant1, global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant2, global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant3> request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Handle access request<br/>
        /// Handle a user's access request to a gated repository
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> CreateDatasetsByNamespaceByRepoUserAccessRequestHandleAsResponseAsync(
            string @namespace,
            string repo,

            global::HuggingFace.OneOf<global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant1, global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant2, global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant3> request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Handle access request<br/>
        /// Handle a user's access request to a gated repository
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetsByNamespaceByRepoUserAccessRequestHandleAsync(
            string @namespace,
            string repo,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}