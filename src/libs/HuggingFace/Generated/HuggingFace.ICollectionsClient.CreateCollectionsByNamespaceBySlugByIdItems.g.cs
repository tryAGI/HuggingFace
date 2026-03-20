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
        global::System.Threading.Tasks.Task<global::HuggingFace.Response164> CreateCollectionsByNamespaceBySlugByIdItemsAsync(
            string @namespace,
            string slug,
            string id,

            global::HuggingFace.Request84 request,
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
        global::System.Threading.Tasks.Task<global::HuggingFace.Response164> CreateCollectionsByNamespaceBySlugByIdItemsAsync(
            string @namespace,
            string slug,
            string id,
            global::HuggingFace.RequestItem item,
            string? note = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}