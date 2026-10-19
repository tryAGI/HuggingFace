#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
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
        global::System.Threading.Tasks.Task CreateModelsByNamespaceByRepoUserAccessRequestHandleAsync(
            string @namespace,
            string repo,

            global::HuggingFace.OneOf<global::HuggingFace.CreateModelsUserAccessRequestHandleRequestVariant1, global::HuggingFace.CreateModelsUserAccessRequestHandleRequestVariant2, global::HuggingFace.CreateModelsUserAccessRequestHandleRequestVariant3> request,
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
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> CreateModelsByNamespaceByRepoUserAccessRequestHandleAsResponseAsync(
            string @namespace,
            string repo,

            global::HuggingFace.OneOf<global::HuggingFace.CreateModelsUserAccessRequestHandleRequestVariant1, global::HuggingFace.CreateModelsUserAccessRequestHandleRequestVariant2, global::HuggingFace.CreateModelsUserAccessRequestHandleRequestVariant3> request,
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
        global::System.Threading.Tasks.Task CreateModelsByNamespaceByRepoUserAccessRequestHandleAsync(
            string @namespace,
            string repo,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}