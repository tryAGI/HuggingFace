#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// Create a new discussion
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response83> CreateByRepoTypeByNamespaceByRepoDiscussionsAsync(
            global::HuggingFace.RepoType28 repoType,
            string @namespace,
            string repo,

            global::HuggingFace.Request39 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new discussion
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="pullRequest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response83> CreateByRepoTypeByNamespaceByRepoDiscussionsAsync(
            global::HuggingFace.RepoType28 repoType,
            string @namespace,
            string repo,
            string title,
            string description,
            bool? pullRequest = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}