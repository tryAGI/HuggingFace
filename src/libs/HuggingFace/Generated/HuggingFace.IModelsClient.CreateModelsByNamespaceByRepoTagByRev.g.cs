#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Create tag
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateModelsByNamespaceByRepoTagByRevAsync(
            string @namespace,
            string repo,
            string rev,

            global::HuggingFace.Request38 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create tag
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="tag"></param>
        /// <param name="message"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateModelsByNamespaceByRepoTagByRevAsync(
            string @namespace,
            string repo,
            string rev,
            string tag,
            string? message = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}