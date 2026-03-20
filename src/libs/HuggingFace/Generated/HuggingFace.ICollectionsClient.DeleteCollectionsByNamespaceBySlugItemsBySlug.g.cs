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
        /// <param name="slug1"></param>
        /// <param name="slug2"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteCollectionsByNamespaceBySlugItemsBySlugAsync(
            string @namespace,
            string slug1,
            string slug2,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}