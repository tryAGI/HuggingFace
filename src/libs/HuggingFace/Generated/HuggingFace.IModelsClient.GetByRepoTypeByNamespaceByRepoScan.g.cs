#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get security status<br/>
        /// Get the security status of a repo
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response81> GetByRepoTypeByNamespaceByRepoScanAsync(
            global::HuggingFace.RepoType26 repoType,
            string @namespace,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}