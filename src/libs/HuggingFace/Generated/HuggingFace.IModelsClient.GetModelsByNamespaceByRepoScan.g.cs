#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get security status<br/>
        /// Get the security status of a repo
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetModelsScanResponse> GetModelsByNamespaceByRepoScanAsync(
            string @namespace,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}