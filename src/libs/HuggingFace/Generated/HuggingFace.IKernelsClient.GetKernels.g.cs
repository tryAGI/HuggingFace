#nullable enable

namespace HuggingFace
{
    public partial interface IKernelsClient
    {
        /// <summary>
        /// List kernels<br/>
        /// List kernels with optional filtering, sorting, and pagination
        /// </summary>
        /// <param name="search">
        /// Filter by search term
        /// </param>
        /// <param name="author">
        /// Filter by author
        /// </param>
        /// <param name="id">
        /// Filter by ID
        /// </param>
        /// <param name="arxivIds">
        /// Filter by Arxiv ID
        /// </param>
        /// <param name="filter">
        /// Filter by tags
        /// </param>
        /// <param name="sort">
        /// Sort field (e.g. downloads, likes, lastModified, trendingScore)<br/>
        /// Default Value: trendingScore
        /// </param>
        /// <param name="direction">
        /// Sort direction: 1 for ascending, -1 for descending<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from Link header
        /// </param>
        /// <param name="full">
        /// Return full kernel info including author, sha, lastModified, files, gated
        /// </param>
        /// <param name="gated">
        /// Filter by gated
        /// </param>
        /// <param name="expand">
        /// Display specific fields in the response
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>> GetKernelsAsync(
            string? search = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? author = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? id = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? arxivIds = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? filter = default,
            global::HuggingFace.GetKernelsSort? sort = default,
            global::HuggingFace.GetKernelsDirection? direction = default,
            int? limit = default,
            string? cursor = default,
            bool? full = default,
            bool? gated = default,
            global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>>? expand = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List kernels<br/>
        /// List kernels with optional filtering, sorting, and pagination
        /// </summary>
        /// <param name="search">
        /// Filter by search term
        /// </param>
        /// <param name="author">
        /// Filter by author
        /// </param>
        /// <param name="id">
        /// Filter by ID
        /// </param>
        /// <param name="arxivIds">
        /// Filter by Arxiv ID
        /// </param>
        /// <param name="filter">
        /// Filter by tags
        /// </param>
        /// <param name="sort">
        /// Sort field (e.g. downloads, likes, lastModified, trendingScore)<br/>
        /// Default Value: trendingScore
        /// </param>
        /// <param name="direction">
        /// Sort direction: 1 for ascending, -1 for descending<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from Link header
        /// </param>
        /// <param name="full">
        /// Return full kernel info including author, sha, lastModified, files, gated
        /// </param>
        /// <param name="gated">
        /// Filter by gated
        /// </param>
        /// <param name="expand">
        /// Display specific fields in the response
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>>> GetKernelsAsResponseAsync(
            string? search = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? author = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? id = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? arxivIds = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? filter = default,
            global::HuggingFace.GetKernelsSort? sort = default,
            global::HuggingFace.GetKernelsDirection? direction = default,
            int? limit = default,
            string? cursor = default,
            bool? full = default,
            bool? gated = default,
            global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>>? expand = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}