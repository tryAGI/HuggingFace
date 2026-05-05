#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.GetModelsNotebookResponseVariant1, global::HuggingFace.GetModelsNotebookResponseVariant2, global::HuggingFace.GetModelsNotebookResponseVariant3>> GetModelsByNamespaceByRepoNotebookByRevByPathAsync(
            string @namespace,
            string repo,
            string rev,
            string path,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.AnyOf<global::HuggingFace.GetModelsNotebookResponseVariant1, global::HuggingFace.GetModelsNotebookResponseVariant2, global::HuggingFace.GetModelsNotebookResponseVariant3>>> GetModelsByNamespaceByRepoNotebookByRevByPathAsResponseAsync(
            string @namespace,
            string repo,
            string rev,
            string path,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}