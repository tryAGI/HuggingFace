#nullable enable

namespace HuggingFace
{
    public partial interface IServiceAccountsClient
    {
        /// <summary>
        /// Trusted publisher
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="publisherId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteOrganizationsByNameServiceAccountsByServiceAccountIdTrustedPublishersByPublisherIdAsync(
            string name,
            string serviceAccountId,
            string publisherId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trusted publisher
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="publisherId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> DeleteOrganizationsByNameServiceAccountsByServiceAccountIdTrustedPublishersByPublisherIdAsResponseAsync(
            string name,
            string serviceAccountId,
            string publisherId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}