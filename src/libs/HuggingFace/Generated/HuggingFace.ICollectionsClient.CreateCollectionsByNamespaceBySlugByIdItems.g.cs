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
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateCollectionsItemsResponse> CreateCollectionsByNamespaceBySlugByIdItemsAsync(
            string @namespace,
            string slug,
            string id,

            global::HuggingFace.CreateCollectionsItemsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add item<br/>
        /// Add an item to a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="id"></param>
        /// <param name="item"></param>
        /// <param name="note"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateCollectionsItemsResponse> CreateCollectionsByNamespaceBySlugByIdItemsAsync(
            string @namespace,
            string slug,
            string id,
            global::HuggingFace.CreateCollectionsItemsRequestItem item,
            string? note = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}