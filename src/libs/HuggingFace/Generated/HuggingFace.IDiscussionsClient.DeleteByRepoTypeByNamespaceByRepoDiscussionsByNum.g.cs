#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// Delete a discussion
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByRepoTypeByNamespaceByRepoDiscussionsByNumAsync(
            global::HuggingFace.DeleteDiscussionsRepoType repoType,
            string @namespace,
            string repo,
            string num,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a discussion
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> DeleteByRepoTypeByNamespaceByRepoDiscussionsByNumAsResponseAsync(
            global::HuggingFace.DeleteDiscussionsRepoType repoType,
            string @namespace,
            string repo,
            string num,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}