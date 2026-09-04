#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {
        /// <summary>
        /// React to comment
        /// </summary>
        /// <param name="paperId"></param>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreatePapersByPaperIdCommentByCommentIdReactionAsync(
            string paperId,
            string commentId,

            global::HuggingFace.CreatePapersCommentReactionRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// React to comment
        /// </summary>
        /// <param name="paperId"></param>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> CreatePapersByPaperIdCommentByCommentIdReactionAsResponseAsync(
            string paperId,
            string commentId,

            global::HuggingFace.CreatePapersCommentReactionRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// React to comment
        /// </summary>
        /// <param name="paperId"></param>
        /// <param name="commentId"></param>
        /// <param name="reaction"></param>
        /// <param name="action"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreatePapersByPaperIdCommentByCommentIdReactionAsync(
            string paperId,
            string commentId,
            global::HuggingFace.CreatePapersCommentReactionRequestReaction reaction,
            global::HuggingFace.CreatePapersCommentReactionRequestAction action,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}