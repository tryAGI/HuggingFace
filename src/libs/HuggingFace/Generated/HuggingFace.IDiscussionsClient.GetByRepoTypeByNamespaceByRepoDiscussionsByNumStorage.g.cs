#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// PR storage estimate<br/>
        /// Estimates the LFS storage used by a PR that could be freed if the ref is deleted.
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetDiscussionsStorageResponse> GetByRepoTypeByNamespaceByRepoDiscussionsByNumStorageAsync(
            global::HuggingFace.GetDiscussionsStorageRepoType repoType,
            string @namespace,
            string repo,
            string num,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// PR storage estimate<br/>
        /// Estimates the LFS storage used by a PR that could be freed if the ref is deleted.
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetDiscussionsStorageResponse>> GetByRepoTypeByNamespaceByRepoDiscussionsByNumStorageAsResponseAsync(
            global::HuggingFace.GetDiscussionsStorageRepoType repoType,
            string @namespace,
            string repo,
            string num,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}