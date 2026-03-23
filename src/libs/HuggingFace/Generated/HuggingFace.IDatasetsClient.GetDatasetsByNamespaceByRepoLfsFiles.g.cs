#nullable enable

namespace HuggingFace
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List Large files<br/>
        /// List Xet/LFS files for a repo
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="xet"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLfsFilesResponseItem>> GetDatasetsByNamespaceByRepoLfsFilesAsync(
            string @namespace,
            string repo,
            string? cursor = default,
            int? limit = default,
            object? xet = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}