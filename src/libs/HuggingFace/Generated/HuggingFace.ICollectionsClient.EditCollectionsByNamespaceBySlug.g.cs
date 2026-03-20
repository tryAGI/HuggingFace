#nullable enable

namespace HuggingFace
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Update a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response163> EditCollectionsByNamespaceBySlugAsync(
            string @namespace,
            string slug,

            global::HuggingFace.Request83 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="position"></param>
        /// <param name="private"></param>
        /// <param name="theme"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="gating"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response163> EditCollectionsByNamespaceBySlugAsync(
            string @namespace,
            string slug,
            int? position = default,
            bool? @private = default,
            global::HuggingFace.RequestTheme2? theme = default,
            string? title = default,
            string? description = default,
            global::HuggingFace.AnyOf<string, global::HuggingFace.RequestGatingVariant22, global::HuggingFace.RequestGatingVariant32>? gating = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}