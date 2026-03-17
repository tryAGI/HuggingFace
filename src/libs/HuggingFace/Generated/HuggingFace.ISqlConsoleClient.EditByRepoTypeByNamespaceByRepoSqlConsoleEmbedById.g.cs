#nullable enable

namespace HuggingFace
{
    public partial interface ISqlConsoleClient
    {
        /// <summary>
        /// Update embed<br/>
        /// Update SQL Console embed
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response101> EditByRepoTypeByNamespaceByRepoSqlConsoleEmbedByIdAsync(
            global::HuggingFace.RepoType46 repoType,
            string @namespace,
            string repo,
            string id,

            global::HuggingFace.Request54 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update embed<br/>
        /// Update SQL Console embed
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="private"></param>
        /// <param name="sql"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response101> EditByRepoTypeByNamespaceByRepoSqlConsoleEmbedByIdAsync(
            global::HuggingFace.RepoType46 repoType,
            string @namespace,
            string repo,
            string id,
            string? title = default,
            bool? @private = default,
            string? sql = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}