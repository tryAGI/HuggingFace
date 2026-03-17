#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Xet write token<br/>
        /// Get a write short-lived access token for XET upload
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response71> GetByRepoTypeByNamespaceByRepoXetWriteTokenByRevAsync(
            global::HuggingFace.RepoType11 repoType,
            string @namespace,
            string repo,
            string rev,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}