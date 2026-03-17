#nullable enable

namespace HuggingFace
{
    public partial interface IPapersClient
    {
        /// <summary>
        /// Claim paper authorship
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response9> CreateSettingsPapersClaimAsync(

            global::HuggingFace.Request6 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Claim paper authorship
        /// </summary>
        /// <param name="paperId">
        /// ArXiv paper identifier being claimed.
        /// </param>
        /// <param name="claimAuthorId">
        /// Author entry on the paper being claimed.
        /// </param>
        /// <param name="targetUserId">
        /// HF user who should receive the claim.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response9> CreateSettingsPapersClaimAsync(
            string paperId,
            string? claimAuthorId = default,
            string? targetUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}