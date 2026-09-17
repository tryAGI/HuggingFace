#nullable enable

namespace HuggingFace
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Create bucket
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateBucketsResponse> CreateBucketsByNamespaceByRepoAsync(
            string @namespace,
            string repo,

            global::HuggingFace.CreateBucketsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create bucket
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateBucketsResponse>> CreateBucketsByNamespaceByRepoAsResponseAsync(
            string @namespace,
            string repo,

            global::HuggingFace.CreateBucketsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create bucket
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="private">
        /// Bucket visibility. Defaults to public
        /// </param>
        /// <param name="resourceGroupId"></param>
        /// <param name="cdn">
        /// CDN pre-warming regions
        /// </param>
        /// <param name="region">
        /// The region where the bucket is hosted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateBucketsResponse> CreateBucketsByNamespaceByRepoAsync(
            string @namespace,
            string repo,
            bool? @private = default,
            string? resourceGroupId = default,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsRequestCdnItem>? cdn = default,
            global::HuggingFace.CreateBucketsRequestRegion? region = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}