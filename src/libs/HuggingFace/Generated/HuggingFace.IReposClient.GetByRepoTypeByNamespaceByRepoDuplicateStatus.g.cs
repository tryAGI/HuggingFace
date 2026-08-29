#nullable enable

namespace HuggingFace
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Duplication status
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetDuplicateStatusResponse> GetByRepoTypeByNamespaceByRepoDuplicateStatusAsync(
            global::HuggingFace.GetDuplicateStatusRepoType repoType,
            string @namespace,
            string repo,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplication status
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetDuplicateStatusResponse>> GetByRepoTypeByNamespaceByRepoDuplicateStatusAsResponseAsync(
            global::HuggingFace.GetDuplicateStatusRepoType repoType,
            string @namespace,
            string repo,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}