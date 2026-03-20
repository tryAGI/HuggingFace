#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {

        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="slug"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response49> CreateBlogBySlugCommentAsync(
            string slug,

            global::HuggingFace.Request24 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="comment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response49> CreateBlogBySlugCommentAsync(
            string slug,
            string comment,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}