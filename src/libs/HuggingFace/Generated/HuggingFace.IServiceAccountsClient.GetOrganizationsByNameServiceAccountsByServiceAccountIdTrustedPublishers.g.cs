#nullable enable

namespace HuggingFace
{
    public partial interface IServiceAccountsClient
    {
        /// <summary>
        /// Trusted publishers<br/>
        /// List the [trusted publishers](https://huggingface.co/docs/hub/trusted-publishers) of a service account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsTrustedPublishersResponseItem>> GetOrganizationsByNameServiceAccountsByServiceAccountIdTrustedPublishersAsync(
            string name,
            string serviceAccountId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trusted publishers<br/>
        /// List the [trusted publishers](https://huggingface.co/docs/hub/trusted-publishers) of a service account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsTrustedPublishersResponseItem>>> GetOrganizationsByNameServiceAccountsByServiceAccountIdTrustedPublishersAsResponseAsync(
            string name,
            string serviceAccountId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}