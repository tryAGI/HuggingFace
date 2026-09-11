#nullable enable

namespace HuggingFace
{
    public partial interface IBlogsClient
    {
        /// <summary>
        /// List blogs
        /// </summary>
        /// <param name="p">
        /// Default Value: 0
        /// </param>
        /// <param name="communitySort">
        /// Default Value: trending
        /// </param>
        /// <param name="tag"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetBlogZhAsync(
            int? p = default,
            global::HuggingFace.GetBlogZhCommunitySort? communitySort = default,
            string? tag = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List blogs
        /// </summary>
        /// <param name="p">
        /// Default Value: 0
        /// </param>
        /// <param name="communitySort">
        /// Default Value: trending
        /// </param>
        /// <param name="tag"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> GetBlogZhAsResponseAsync(
            int? p = default,
            global::HuggingFace.GetBlogZhCommunitySort? communitySort = default,
            string? tag = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}