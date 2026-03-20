#nullable enable

namespace HuggingFace
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get notebook URL<br/>
        /// Get a jupyter notebook URL for the requested file
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="path">
        /// Wildcard path parameter
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.ResponseVariant12, global::HuggingFace.ResponseVariant22, global::HuggingFace.ResponseVariant32>> GetDatasetsByNamespaceByRepoNotebookByRevByPathAsync(
            string @namespace,
            string repo,
            string rev,
            string path,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}