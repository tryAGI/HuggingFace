#nullable enable

namespace HuggingFace
{
    public partial interface IServiceAccountsClient
    {
        /// <summary>
        /// Delete service account<br/>
        /// Delete a service account and all its tokens. This action cannot be undone.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteOrganizationsByNameServiceAccountsByServiceAccountIdAsync(
            string name,
            string serviceAccountId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete service account<br/>
        /// Delete a service account and all its tokens. This action cannot be undone.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<string>> DeleteOrganizationsByNameServiceAccountsByServiceAccountIdAsResponseAsync(
            string name,
            string serviceAccountId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}