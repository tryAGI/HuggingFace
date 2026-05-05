#nullable enable

namespace HuggingFace
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Add item<br/>
        /// Add an item to a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateCollectionsItemsResponse2> CreateCollectionsByNamespaceBySlugItemsAsync(
            string @namespace,
            string slug,

            global::HuggingFace.CreateCollectionsItemsRequest2 request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add item<br/>
        /// Add an item to a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateCollectionsItemsResponse2>> CreateCollectionsByNamespaceBySlugItemsAsResponseAsync(
            string @namespace,
            string slug,

            global::HuggingFace.CreateCollectionsItemsRequest2 request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add item<br/>
        /// Add an item to a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="item"></param>
        /// <param name="note"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateCollectionsItemsResponse2> CreateCollectionsByNamespaceBySlugItemsAsync(
            string @namespace,
            string slug,
            global::HuggingFace.CreateCollectionsItemsRequestItem2 item,
            string? note = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}