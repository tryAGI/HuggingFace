#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Set Space volumes
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task PutSpacesByNamespaceByRepoVolumesAsync(
            string @namespace,
            string repo,

            global::HuggingFace.PutSpacesVolumesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Space volumes
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="volumes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutSpacesByNamespaceByRepoVolumesAsync(
            string @namespace,
            string repo,
            global::System.Collections.Generic.IList<global::HuggingFace.PutSpacesVolumesRequestVolume> volumes,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}