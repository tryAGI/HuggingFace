#nullable enable

namespace HuggingFace
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Get a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response121> GetCollectionsByNamespaceBySlugAsync(
            string @namespace,
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}