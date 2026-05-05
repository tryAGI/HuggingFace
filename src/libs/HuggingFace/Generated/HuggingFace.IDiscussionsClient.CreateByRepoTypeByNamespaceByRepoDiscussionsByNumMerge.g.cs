#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// Merge a pull request
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByRepoTypeByNamespaceByRepoDiscussionsByNumMergeAsync(
            global::HuggingFace.CreateDiscussionsMergeRepoType repoType,
            string @namespace,
            string repo,
            string num,

            global::HuggingFace.CreateDiscussionsMergeRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Merge a pull request
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> CreateByRepoTypeByNamespaceByRepoDiscussionsByNumMergeAsResponseAsync(
            global::HuggingFace.CreateDiscussionsMergeRepoType repoType,
            string @namespace,
            string repo,
            string num,

            global::HuggingFace.CreateDiscussionsMergeRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Merge a pull request
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="comment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByRepoTypeByNamespaceByRepoDiscussionsByNumMergeAsync(
            global::HuggingFace.CreateDiscussionsMergeRepoType repoType,
            string @namespace,
            string repo,
            string num,
            string? comment = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}