#nullable enable

namespace HuggingFace
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// List files
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="path">
        /// Wildcard path parameter
        /// </param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor
        /// </param>
        /// <param name="recursive">
        /// When false, returns collapsed directory entries instead of listing all files recursively. The number of entries returned can then be less than the limit, but there will always be a pagination link if there are more entries. Note: non-recursive listing hasn't a strong consistency guarantees.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsTreeResponseItem>> GetBucketsByNamespaceByRepoTreeByPathAsync(
            string @namespace,
            string repo,
            string path,
            int? limit = default,
            string? cursor = default,
            object? recursive = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List files
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="path">
        /// Wildcard path parameter
        /// </param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor
        /// </param>
        /// <param name="recursive">
        /// When false, returns collapsed directory entries instead of listing all files recursively. The number of entries returned can then be less than the limit, but there will always be a pagination link if there are more entries. Note: non-recursive listing hasn't a strong consistency guarantees.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsTreeResponseItem>>> GetBucketsByNamespaceByRepoTreeByPathAsResponseAsync(
            string @namespace,
            string repo,
            string path,
            int? limit = default,
            string? cursor = default,
            object? recursive = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}