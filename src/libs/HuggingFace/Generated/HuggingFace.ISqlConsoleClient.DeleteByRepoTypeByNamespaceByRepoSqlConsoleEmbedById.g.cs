#nullable enable

namespace HuggingFace
{
    public partial interface ISqlConsoleClient
    {
        /// <summary>
        /// Delete embed<br/>
        /// Delete SQL Console embed
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response126> DeleteByRepoTypeByNamespaceByRepoSqlConsoleEmbedByIdAsync(
            global::HuggingFace.RepoType26 repoType,
            string @namespace,
            string repo,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}