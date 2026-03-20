#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {

        /// <summary>
        /// Get a compare rev
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="compare"></param>
        /// <param name="raw">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetSpacesByNamespaceByRepoCompareByCompareAsync(
            string @namespace,
            string repo,
            string compare,
            object? raw = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}