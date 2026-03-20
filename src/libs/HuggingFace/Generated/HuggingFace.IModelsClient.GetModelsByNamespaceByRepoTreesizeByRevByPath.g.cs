#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {

        /// <summary>
        /// Get folder size<br/>
        /// Get the total size of a repository at a given revision, optionally under a specific subpath. Returns the total size in bytes of all files under the specified path (recursively). If a file is stored via Xet/LFS, the LFS file size is used.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="path">
        /// Wildcard path parameter
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response67> GetModelsByNamespaceByRepoTreesizeByRevByPathAsync(
            string @namespace,
            string repo,
            string rev,
            string path,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}