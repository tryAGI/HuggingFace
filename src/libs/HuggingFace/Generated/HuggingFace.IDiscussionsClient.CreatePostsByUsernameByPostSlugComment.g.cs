#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="username"></param>
        /// <param name="postSlug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreatePostsCommentResponse> CreatePostsByUsernameByPostSlugCommentAsync(
            string username,
            string postSlug,

            global::HuggingFace.CreatePostsCommentRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="username"></param>
        /// <param name="postSlug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreatePostsCommentResponse>> CreatePostsByUsernameByPostSlugCommentAsResponseAsync(
            string username,
            string postSlug,

            global::HuggingFace.CreatePostsCommentRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="username"></param>
        /// <param name="postSlug"></param>
        /// <param name="comment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreatePostsCommentResponse> CreatePostsByUsernameByPostSlugCommentAsync(
            string username,
            string postSlug,
            string comment,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}