#nullable enable

namespace HuggingFace
{
    public partial interface IPapersClient
    {
        /// <summary>
        /// List papers<br/>
        /// List arXiv papers sorted by published date
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseItem>> GetPapersAsync(
            string? cursor = default,
            int? limit = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List papers<br/>
        /// List arXiv papers sorted by published date
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseItem>>> GetPapersAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}