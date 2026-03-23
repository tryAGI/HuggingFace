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
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreatePostsCommentReplyResponse> CreatePostsByUsernameByPostSlugCommentByCommentIdReplyAsync(
            string username,
            string postSlug,
            string commentId,

            global::HuggingFace.CreatePostsCommentReplyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="username"></param>
        /// <param name="postSlug"></param>
        /// <param name="commentId"></param>
        /// <param name="comment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreatePostsCommentReplyResponse> CreatePostsByUsernameByPostSlugCommentByCommentIdReplyAsync(
            string username,
            string postSlug,
            string commentId,
            string comment,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}