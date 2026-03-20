#nullable enable

namespace HuggingFace
{
    public partial interface IDatasetsClient
    {

        /// <summary>
        /// Xet read token<br/>
        /// Get a read short-lived access token for XET
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response85> GetDatasetsByNamespaceByRepoXetReadTokenByRevAsync(
            string @namespace,
            string repo,
            string rev,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}