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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByRepoTypeByNamespaceByRepoDiscussionsByNumMergeAsync(
            global::HuggingFace.RepoType17 repoType,
            string @namespace,
            string repo,
            string num,

            global::HuggingFace.Request56 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Merge a pull request
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="comment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByRepoTypeByNamespaceByRepoDiscussionsByNumMergeAsync(
            global::HuggingFace.RepoType17 repoType,
            string @namespace,
            string repo,
            string num,
            string? comment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}