#nullable enable

namespace HuggingFace
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Get collections
        /// </summary>
        /// <param name="item"></param>
        /// <param name="owner"></param>
        /// <param name="q"></param>
        /// <param name="sort">
        /// Default Value: trending
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="expand">
        /// Default Value: true
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1Item>, global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant2Item>>> GetCollectionsAsync(
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string>? item = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.Dictionary<string, string>>? owner = default,
            string? q = default,
            global::HuggingFace.GetCollectionsSort? sort = default,
            string? cursor = default,
            object? expand = default,
            double? limit = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get collections
        /// </summary>
        /// <param name="item"></param>
        /// <param name="owner"></param>
        /// <param name="q"></param>
        /// <param name="sort">
        /// Default Value: trending
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="expand">
        /// Default Value: true
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1Item>, global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant2Item>>>> GetCollectionsAsResponseAsync(
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string>? item = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.Dictionary<string, string>>? owner = default,
            string? q = default,
            global::HuggingFace.GetCollectionsSort? sort = default,
            string? cursor = default,
            object? expand = default,
            double? limit = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}