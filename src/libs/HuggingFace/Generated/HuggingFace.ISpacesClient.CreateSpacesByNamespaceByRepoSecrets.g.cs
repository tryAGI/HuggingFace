#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Upsert secret<br/>
        /// Upsert Spaces's secret
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateSpacesByNamespaceByRepoSecretsAsync(
            string @namespace,
            string repo,

            global::HuggingFace.Request46 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upsert secret<br/>
        /// Upsert Spaces's secret
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="key"></param>
        /// <param name="description"></param>
        /// <param name="value"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateSpacesByNamespaceByRepoSecretsAsync(
            string @namespace,
            string repo,
            string key,
            string? description = default,
            string? value = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}