#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// Pin a discussion
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByRepoTypeByNamespaceByRepoDiscussionsByNumPinAsync(
            global::HuggingFace.CreateDiscussionsPinRepoType repoType,
            string @namespace,
            string repo,
            string num,

            global::HuggingFace.CreateDiscussionsPinRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pin a discussion
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="pinned"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByRepoTypeByNamespaceByRepoDiscussionsByNumPinAsync(
            global::HuggingFace.CreateDiscussionsPinRepoType repoType,
            string @namespace,
            string repo,
            string num,
            bool pinned,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}