#nullable enable

namespace HuggingFace
{
    public partial interface IPapersClient
    {
        /// <summary>
        /// Update paper media<br/>
        /// Replace the media shown on a Daily Papers submission. Requires the requester to be the paper author, the Daily Papers submitter, or a papers admin.
        /// </summary>
        /// <param name="paperId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreatePapersMediaResponse> CreatePapersByPaperIdMediaAsync(
            string paperId,

            global::HuggingFace.CreatePapersMediaRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update paper media<br/>
        /// Replace the media shown on a Daily Papers submission. Requires the requester to be the paper author, the Daily Papers submitter, or a papers admin.
        /// </summary>
        /// <param name="paperId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreatePapersMediaResponse>> CreatePapersByPaperIdMediaAsResponseAsync(
            string paperId,

            global::HuggingFace.CreatePapersMediaRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update paper media<br/>
        /// Replace the media shown on a Daily Papers submission. Requires the requester to be the paper author, the Daily Papers submitter, or a papers admin.
        /// </summary>
        /// <param name="paperId"></param>
        /// <param name="mediaUrls">
        /// Media URLs, in display order
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreatePapersMediaResponse> CreatePapersByPaperIdMediaAsync(
            string paperId,
            global::System.Collections.Generic.IList<string> mediaUrls,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}