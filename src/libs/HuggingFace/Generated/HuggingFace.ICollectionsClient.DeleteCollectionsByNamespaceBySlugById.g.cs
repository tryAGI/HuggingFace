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
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteCollectionsByNamespaceBySlugByIdAsync(
            string @namespace,
            string slug,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}