#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Stream logs<br/>
        /// Get logs for a specific Space in a streaming fashion, with SSE protocol
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="logType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetSpacesByNamespaceByRepoLogsByLogTypeAsync(
            string @namespace,
            string repo,
            global::HuggingFace.LogType logType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}