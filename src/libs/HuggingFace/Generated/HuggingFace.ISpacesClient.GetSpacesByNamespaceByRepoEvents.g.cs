#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Stream events<br/>
        /// Get status updates for a specific Space in a streaming fashion, with SSE protocol
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="sessionUuid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetSpacesByNamespaceByRepoEventsAsync(
            string @namespace,
            string repo,
            string? sessionUuid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}