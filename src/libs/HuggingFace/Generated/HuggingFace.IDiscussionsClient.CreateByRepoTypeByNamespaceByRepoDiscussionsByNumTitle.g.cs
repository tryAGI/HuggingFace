#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// Change title<br/>
        /// Change the title of a discussion
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response110> CreateByRepoTypeByNamespaceByRepoDiscussionsByNumTitleAsync(
            global::HuggingFace.RepoType15 repoType,
            string @namespace,
            string repo,
            string num,

            global::HuggingFace.Request54 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change title<br/>
        /// Change the title of a discussion
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="title"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response110> CreateByRepoTypeByNamespaceByRepoDiscussionsByNumTitleAsync(
            global::HuggingFace.RepoType15 repoType,
            string @namespace,
            string repo,
            string num,
            string title,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}