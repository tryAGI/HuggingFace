#nullable enable

namespace HuggingFace
{
    public partial interface IServiceAccountsClient
    {
        /// <summary>
        /// Rotate service-account token<br/>
        /// Invalidate an existing token and generate a new one with the same permissions. The old token will stop working immediately.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRotateResponse> CreateOrganizationsByNameServiceAccountsByServiceAccountIdTokensByTokenIdRotateAsync(
            string name,
            string serviceAccountId,
            string tokenId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate service-account token<br/>
        /// Invalidate an existing token and generate a new one with the same permissions. The old token will stop working immediately.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRotateResponse>> CreateOrganizationsByNameServiceAccountsByServiceAccountIdTokensByTokenIdRotateAsResponseAsync(
            string name,
            string serviceAccountId,
            string tokenId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}