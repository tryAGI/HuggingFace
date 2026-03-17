#nullable enable

namespace HuggingFace
{
    public partial interface ISqlConsoleClient
    {
        /// <summary>
        /// Create embed<br/>
        /// Create SQL Console embed
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response103> CreateByRepoTypeByNamespaceByRepoSqlConsoleEmbedAsync(
            global::HuggingFace.RepoType48 repoType,
            string @namespace,
            string repo,

            global::HuggingFace.Request55 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create embed<br/>
        /// Create SQL Console embed
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="sql"></param>
        /// <param name="title"></param>
        /// <param name="private"></param>
        /// <param name="views"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response103> CreateByRepoTypeByNamespaceByRepoSqlConsoleEmbedAsync(
            global::HuggingFace.RepoType48 repoType,
            string @namespace,
            string repo,
            string sql,
            string title,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestView> views,
            bool? @private = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}