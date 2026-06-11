#nullable enable

namespace HuggingFace
{
    public partial interface IServiceAccountsClient
    {
        /// <summary>
        /// Delete service-account token<br/>
        /// Delete an access token from a service account. This action cannot be undone.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteOrganizationsByNameServiceAccountsByServiceAccountIdTokensByTokenIdAsync(
            string name,
            string serviceAccountId,
            string tokenId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete service-account token<br/>
        /// Delete an access token from a service account. This action cannot be undone.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<string>> DeleteOrganizationsByNameServiceAccountsByServiceAccountIdTokensByTokenIdAsResponseAsync(
            string name,
            string serviceAccountId,
            string tokenId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}