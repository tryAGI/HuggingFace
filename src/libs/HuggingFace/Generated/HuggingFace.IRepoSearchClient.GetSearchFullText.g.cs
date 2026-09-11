#nullable enable

namespace HuggingFace
{
    public partial interface IRepoSearchClient
    {
        /// <summary>
        /// Full-text search
        /// </summary>
        /// <param name="q"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="type"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetSearchFullTextAsync(
            string? q = default,
            int? limit = default,
            int? skip = default,
            global::HuggingFace.AnyOf<global::HuggingFace.GetSearchFullTextType2?, global::System.Collections.Generic.IList<global::HuggingFace.GetSearchFullTextTypeItem>>? type = default,
            string? filter = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Full-text search
        /// </summary>
        /// <param name="q"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="type"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> GetSearchFullTextAsResponseAsync(
            string? q = default,
            int? limit = default,
            int? skip = default,
            global::HuggingFace.AnyOf<global::HuggingFace.GetSearchFullTextType2?, global::System.Collections.Generic.IList<global::HuggingFace.GetSearchFullTextTypeItem>>? type = default,
            string? filter = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}