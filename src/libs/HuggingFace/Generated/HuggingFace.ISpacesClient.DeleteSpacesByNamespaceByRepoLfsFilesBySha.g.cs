#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Delete Large file<br/>
        /// Delete a Xet/LFS file
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="sha"></param>
        /// <param name="rewriteHistory">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSpacesByNamespaceByRepoLfsFilesByShaAsync(
            string @namespace,
            string repo,
            string sha,
            object? rewriteHistory = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}