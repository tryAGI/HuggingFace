#nullable enable

namespace HuggingFace
{
    public partial interface IPapersClient
    {
        /// <summary>
        /// Update paper links<br/>
        /// Update the project page, GitHub repository, or submitting organization for a paper. Requires the requester to be the paper author, the Daily Papers submitter, or a papers admin.
        /// </summary>
        /// <param name="paperId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreatePapersLinksResponse> CreatePapersByPaperIdLinksAsync(
            string paperId,

            global::HuggingFace.CreatePapersLinksRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update paper links<br/>
        /// Update the project page, GitHub repository, or submitting organization for a paper. Requires the requester to be the paper author, the Daily Papers submitter, or a papers admin.
        /// </summary>
        /// <param name="paperId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreatePapersLinksResponse>> CreatePapersByPaperIdLinksAsResponseAsync(
            string paperId,

            global::HuggingFace.CreatePapersLinksRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update paper links<br/>
        /// Update the project page, GitHub repository, or submitting organization for a paper. Requires the requester to be the paper author, the Daily Papers submitter, or a papers admin.
        /// </summary>
        /// <param name="paperId"></param>
        /// <param name="projectPage"></param>
        /// <param name="githubRepo"></param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreatePapersLinksResponse> CreatePapersByPaperIdLinksAsync(
            string paperId,
            string? projectPage = default,
            string? githubRepo = default,
            string? organizationId = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}