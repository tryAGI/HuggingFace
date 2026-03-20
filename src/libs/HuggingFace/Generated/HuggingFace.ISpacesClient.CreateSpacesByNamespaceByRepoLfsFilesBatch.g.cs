#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Delete Large files<br/>
        /// Delete Xet/LFS files in batch
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateSpacesByNamespaceByRepoLfsFilesBatchAsync(
            string @namespace,
            string repo,

            global::HuggingFace.Request31 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Large files<br/>
        /// Delete Xet/LFS files in batch
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="deletions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateSpacesByNamespaceByRepoLfsFilesBatchAsync(
            string @namespace,
            string repo,
            global::HuggingFace.RequestDeletions3 deletions,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}