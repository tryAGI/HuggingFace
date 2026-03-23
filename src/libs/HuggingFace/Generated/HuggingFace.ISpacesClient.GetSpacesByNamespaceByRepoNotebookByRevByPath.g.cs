#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
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
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.GetSpacesNotebookResponseVariant1, global::HuggingFace.GetSpacesNotebookResponseVariant2, global::HuggingFace.GetSpacesNotebookResponseVariant3>> GetSpacesByNamespaceByRepoNotebookByRevByPathAsync(
            string @namespace,
            string repo,
            string rev,
            string path,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}