#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateBlogCommentReplyResponse2> CreateBlogByNamespaceBySlugCommentByCommentIdReplyAsync(
            string @namespace,
            string slug,
            string commentId,

            global::HuggingFace.CreateBlogCommentReplyRequest2 request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateBlogCommentReplyResponse2>> CreateBlogByNamespaceBySlugCommentByCommentIdReplyAsResponseAsync(
            string @namespace,
            string slug,
            string commentId,

            global::HuggingFace.CreateBlogCommentReplyRequest2 request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="commentId"></param>
        /// <param name="comment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateBlogCommentReplyResponse2> CreateBlogByNamespaceBySlugCommentByCommentIdReplyAsync(
            string @namespace,
            string slug,
            string commentId,
            string comment,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}