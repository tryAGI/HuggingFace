#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {

        /// <summary>
        /// Delete secret<br/>
        /// Delete Spaces's secret
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSpacesByNamespaceByRepoSecretsAsync(
            string @namespace,
            string repo,

            global::HuggingFace.Request59 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete secret<br/>
        /// Delete Spaces's secret
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="key"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteSpacesByNamespaceByRepoSecretsAsync(
            string @namespace,
            string repo,
            string key,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}