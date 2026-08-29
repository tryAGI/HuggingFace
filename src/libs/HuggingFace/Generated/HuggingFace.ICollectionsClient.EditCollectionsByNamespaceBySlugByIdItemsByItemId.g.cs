#nullable enable

namespace HuggingFace
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Update item<br/>
        /// Update an item in a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="id"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task EditCollectionsByNamespaceBySlugByIdItemsByItemIdAsync(
            string @namespace,
            string slug,
            string id,
            string itemId,

            global::HuggingFace.PatchCollectionsItemsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update item<br/>
        /// Update an item in a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="id"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> EditCollectionsByNamespaceBySlugByIdItemsByItemIdAsResponseAsync(
            string @namespace,
            string slug,
            string id,
            string itemId,

            global::HuggingFace.PatchCollectionsItemsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update item<br/>
        /// Update an item in a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="id"></param>
        /// <param name="itemId"></param>
        /// <param name="gallery"></param>
        /// <param name="note"></param>
        /// <param name="position"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EditCollectionsByNamespaceBySlugByIdItemsByItemIdAsync(
            string @namespace,
            string slug,
            string id,
            string itemId,
            global::System.Collections.Generic.IList<string>? gallery = default,
            string? note = default,
            int? position = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}