#nullable enable

namespace HuggingFace
{
    public partial interface ICollectionsClient
    {

        /// <summary>
        /// Delete a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteCollectionsByNamespaceBySlugAsync(
            string @namespace,
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}