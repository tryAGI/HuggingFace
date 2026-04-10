#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List access requests<br/>
        /// List access requests for a gated repository
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="status"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetModelsUserAccessRequestResponseItem>> GetModelsByNamespaceByRepoUserAccessRequestByStatusAsync(
            string @namespace,
            string repo,
            global::HuggingFace.GetModelsUserAccessRequestStatus status,
            int? limit = default,
            global::System.DateTime? after = default,
            global::System.DateTime? before = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List access requests<br/>
        /// List access requests for a gated repository
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="status"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetModelsUserAccessRequestResponseItem>>> GetModelsByNamespaceByRepoUserAccessRequestByStatusAsResponseAsync(
            string @namespace,
            string repo,
            global::HuggingFace.GetModelsUserAccessRequestStatus status,
            int? limit = default,
            global::System.DateTime? after = default,
            global::System.DateTime? before = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}