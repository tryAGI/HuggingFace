#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response86> CreateByRepoTypeByNamespaceByRepoDiscussionsByNumCommentAsync(
            global::HuggingFace.RepoType31 repoType,
            string @namespace,
            string repo,
            string num,

            global::HuggingFace.Request40 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="comment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response86> CreateByRepoTypeByNamespaceByRepoDiscussionsByNumCommentAsync(
            global::HuggingFace.RepoType31 repoType,
            string @namespace,
            string repo,
            string num,
            string comment,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}