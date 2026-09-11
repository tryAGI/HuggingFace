#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Semantic search
        /// </summary>
        /// <param name="q"></param>
        /// <param name="category"></param>
        /// <param name="includeNonRunning"></param>
        /// <param name="sdk"></param>
        /// <param name="filter"></param>
        /// <param name="agents"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetSpacesSemanticSearchAsync(
            string? q = default,
            global::HuggingFace.GetSpacesSemanticSearchCategory? category = default,
            bool? includeNonRunning = default,
            global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesSemanticSearchSdkItem>? sdk = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            bool? agents = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Semantic search
        /// </summary>
        /// <param name="q"></param>
        /// <param name="category"></param>
        /// <param name="includeNonRunning"></param>
        /// <param name="sdk"></param>
        /// <param name="filter"></param>
        /// <param name="agents"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> GetSpacesSemanticSearchAsResponseAsync(
            string? q = default,
            global::HuggingFace.GetSpacesSemanticSearchCategory? category = default,
            bool? includeNonRunning = default,
            global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesSemanticSearchSdkItem>? sdk = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            bool? agents = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}