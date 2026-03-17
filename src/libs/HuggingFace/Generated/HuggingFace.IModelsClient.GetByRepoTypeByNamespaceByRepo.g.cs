#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get kernel
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response90> GetByRepoTypeByNamespaceByRepoAsync(
            global::HuggingFace.RepoType38 repoType,
            string @namespace,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}