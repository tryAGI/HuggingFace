#nullable enable

namespace HuggingFace
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List references
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="includePrs">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response71> GetDatasetsByNamespaceByRepoRefsAsync(
            string @namespace,
            string repo,
            object? includePrs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}