#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// React to comment
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateBlogBySlugCommentByCommentIdReactionAsync(
            string slug,
            string commentId,

            global::HuggingFace.CreateBlogCommentReactionRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// React to comment
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> CreateBlogBySlugCommentByCommentIdReactionAsResponseAsync(
            string slug,
            string commentId,

            global::HuggingFace.CreateBlogCommentReactionRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// React to comment
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="commentId"></param>
        /// <param name="reaction"></param>
        /// <param name="action"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateBlogBySlugCommentByCommentIdReactionAsync(
            string slug,
            string commentId,
            global::HuggingFace.CreateBlogCommentReactionRequestReaction reaction,
            global::HuggingFace.CreateBlogCommentReactionRequestAction action,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}