#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// List Large files<br/>
        /// List Xet/LFS files for a repo
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cursor"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="sort">
        /// Default Value: size
        /// </param>
        /// <param name="xet"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesLfsFilesResponseItem>> GetSpacesByNamespaceByRepoLfsFilesAsync(
            string @namespace,
            string repo,
            string? cursor = default,
            global::HuggingFace.GetSpacesLfsFilesDirection? direction = default,
            int? limit = default,
            global::HuggingFace.GetSpacesLfsFilesSort? sort = default,
            object? xet = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Large files<br/>
        /// List Xet/LFS files for a repo
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cursor"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="sort">
        /// Default Value: size
        /// </param>
        /// <param name="xet"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesLfsFilesResponseItem>>> GetSpacesByNamespaceByRepoLfsFilesAsResponseAsync(
            string @namespace,
            string repo,
            string? cursor = default,
            global::HuggingFace.GetSpacesLfsFilesDirection? direction = default,
            int? limit = default,
            global::HuggingFace.GetSpacesLfsFilesSort? sort = default,
            object? xet = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}