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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response124> CreateCollectionsByNamespaceBySlugItemsAsync(
            string @namespace,
            string slug,

            global::HuggingFace.Request69 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add item<br/>
        /// Add an item to a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="item"></param>
        /// <param name="note"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response124> CreateCollectionsByNamespaceBySlugItemsAsync(
            string @namespace,
            string slug,
            global::HuggingFace.RequestItem2 item,
            string? note = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}