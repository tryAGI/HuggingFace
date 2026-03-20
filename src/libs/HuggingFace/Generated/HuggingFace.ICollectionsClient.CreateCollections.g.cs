#nullable enable

namespace HuggingFace
{
    public partial interface ICollectionsClient
    {

        /// <summary>
        /// Create a collection
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response166> CreateCollectionsAsync(

            global::HuggingFace.Request86 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a collection
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="namespace"></param>
        /// <param name="item"></param>
        /// <param name="private">
        /// If not provided, the collection will be public. This field will respect the organization's visibility setting.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response166> CreateCollectionsAsync(
            string title,
            string @namespace,
            string? description = default,
            global::HuggingFace.RequestItem5? item = default,
            bool? @private = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}