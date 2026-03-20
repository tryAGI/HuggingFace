#nullable enable

namespace HuggingFace
{
    public partial interface ICollectionsClient
    {

        /// <summary>
        /// Delete item<br/>
        /// Delete an item from a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="id"></param>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteCollectionsByNamespaceBySlugByIdItemsByItemIdAsync(
            string @namespace,
            string slug,
            string id,
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}