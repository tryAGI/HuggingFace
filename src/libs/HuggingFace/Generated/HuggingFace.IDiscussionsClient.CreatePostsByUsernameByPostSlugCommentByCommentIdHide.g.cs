#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// Hide comment
        /// </summary>
        /// <param name="username"></param>
        /// <param name="postSlug"></param>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreatePostsByUsernameByPostSlugCommentByCommentIdHideAsync(
            string username,
            string postSlug,
            string commentId,

            global::HuggingFace.CreatePostsCommentHideRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Hide comment
        /// </summary>
        /// <param name="username"></param>
        /// <param name="postSlug"></param>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> CreatePostsByUsernameByPostSlugCommentByCommentIdHideAsResponseAsync(
            string username,
            string postSlug,
            string commentId,

            global::HuggingFace.CreatePostsCommentHideRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Hide comment
        /// </summary>
        /// <param name="username"></param>
        /// <param name="postSlug"></param>
        /// <param name="commentId"></param>
        /// <param name="reason"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreatePostsByUsernameByPostSlugCommentByCommentIdHideAsync(
            string username,
            string postSlug,
            string commentId,
            global::HuggingFace.CreatePostsCommentHideRequestReason? reason = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}