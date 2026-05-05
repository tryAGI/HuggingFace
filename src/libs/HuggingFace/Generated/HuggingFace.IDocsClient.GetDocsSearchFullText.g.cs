#nullable enable

namespace HuggingFace
{
    public partial interface IDocsClient
    {
        /// <summary>
        /// Full-text search docs<br/>
        /// Full-text search across Hugging Face documentation
        /// </summary>
        /// <param name="q"></param>
        /// <param name="limit">
        /// Default Value: 9
        /// </param>
        /// <param name="domain"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetDocsSearchFullTextResponse> GetDocsSearchFullTextAsync(
            string q,
            int? limit = default,
            string? domain = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Full-text search docs<br/>
        /// Full-text search across Hugging Face documentation
        /// </summary>
        /// <param name="q"></param>
        /// <param name="limit">
        /// Default Value: 9
        /// </param>
        /// <param name="domain"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetDocsSearchFullTextResponse>> GetDocsSearchFullTextAsResponseAsync(
            string q,
            int? limit = default,
            string? domain = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}