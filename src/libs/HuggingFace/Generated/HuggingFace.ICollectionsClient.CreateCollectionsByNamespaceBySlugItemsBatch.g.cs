#nullable enable

namespace HuggingFace
{
    public partial interface ICollectionsClient
    {

        /// <summary>
        /// Batch update items<br/>
        /// Batch update items in a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateCollectionsByNamespaceBySlugItemsBatchAsync(
            string @namespace,
            string slug,

            global::System.Collections.Generic.IList<global::HuggingFace.RequestItem4> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}