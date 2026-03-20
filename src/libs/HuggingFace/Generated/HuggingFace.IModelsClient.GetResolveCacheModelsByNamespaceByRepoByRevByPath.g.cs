#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Resolve a file<br/>
        /// This endpoint requires to follow redirection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="path">
        /// Wildcard path parameter
        /// </param>
        /// <param name="range">
        /// The range in bytes of the file to download
        /// </param>
        /// <param name="accept">
        /// Returns json information about the XET file info - if the file is a xet file
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response148> GetResolveCacheModelsByNamespaceByRepoByRevByPathAsync(
            string @namespace,
            string repo,
            string rev,
            string path,
            string? range = default,
            string? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}