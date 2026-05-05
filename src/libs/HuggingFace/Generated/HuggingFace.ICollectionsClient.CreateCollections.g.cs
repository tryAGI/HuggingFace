#nullable enable

namespace HuggingFace
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Create a collection
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateCollectionsResponse> CreateCollectionsAsync(

            global::HuggingFace.CreateCollectionsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a collection
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateCollectionsResponse>> CreateCollectionsAsResponseAsync(

            global::HuggingFace.CreateCollectionsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateCollectionsResponse> CreateCollectionsAsync(
            string title,
            string @namespace,
            string? description = default,
            global::HuggingFace.CreateCollectionsRequestItem? item = default,
            bool? @private = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}