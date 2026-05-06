#nullable enable

namespace HuggingFace
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Retrieve information about a file in a bucket<br/>
        /// Returns file metadata including size, hash, and links to XET authentication
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="path">
        /// Wildcard path parameter
        /// </param>
        /// <param name="noContentDisposition"></param>
        /// <param name="download"></param>
        /// <param name="accept">
        /// Returns json information about the XET file info
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetBucketsResolveResponse> GetBucketsByNamespaceByRepoResolveByPathAsync(
            string @namespace,
            string repo,
            string path,
            object? noContentDisposition = default,
            object? download = default,
            string? accept = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve information about a file in a bucket<br/>
        /// Returns file metadata including size, hash, and links to XET authentication
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="path">
        /// Wildcard path parameter
        /// </param>
        /// <param name="noContentDisposition"></param>
        /// <param name="download"></param>
        /// <param name="accept">
        /// Returns json information about the XET file info
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetBucketsResolveResponse>> GetBucketsByNamespaceByRepoResolveByPathAsResponseAsync(
            string @namespace,
            string repo,
            string path,
            object? noContentDisposition = default,
            object? download = default,
            string? accept = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}