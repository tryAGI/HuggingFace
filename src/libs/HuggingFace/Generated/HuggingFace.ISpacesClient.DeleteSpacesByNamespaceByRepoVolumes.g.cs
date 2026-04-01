#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Delete Space volumes
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSpacesByNamespaceByRepoVolumesAsync(
            string @namespace,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}