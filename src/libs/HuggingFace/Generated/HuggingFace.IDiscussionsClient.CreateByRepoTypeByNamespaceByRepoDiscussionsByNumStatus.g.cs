#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// Change status<br/>
        /// Change the status of a discussion
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateDiscussionsStatusResponse> CreateByRepoTypeByNamespaceByRepoDiscussionsByNumStatusAsync(
            global::HuggingFace.CreateDiscussionsStatusRepoType repoType,
            string @namespace,
            string repo,
            string num,

            global::HuggingFace.CreateDiscussionsStatusRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change status<br/>
        /// Change the status of a discussion
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="status"></param>
        /// <param name="comment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateDiscussionsStatusResponse> CreateByRepoTypeByNamespaceByRepoDiscussionsByNumStatusAsync(
            global::HuggingFace.CreateDiscussionsStatusRepoType repoType,
            string @namespace,
            string repo,
            string num,
            global::HuggingFace.CreateDiscussionsStatusRequestStatus status,
            string? comment = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}