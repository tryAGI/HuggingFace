#nullable enable

namespace HuggingFace
{
    public partial interface IServiceAccountsClient
    {
        /// <summary>
        /// Trusted publisher<br/>
        /// Let OIDC tokens matching the issuer and claims exchange for a short-lived token of the service account, with `resource` set to the service account name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsServiceAccountsTrustedPublishersResponse> CreateOrganizationsByNameServiceAccountsByServiceAccountIdTrustedPublishersAsync(
            string name,
            string serviceAccountId,

            global::HuggingFace.CreateOrganizationsServiceAccountsTrustedPublishersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trusted publisher<br/>
        /// Let OIDC tokens matching the issuer and claims exchange for a short-lived token of the service account, with `resource` set to the service account name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateOrganizationsServiceAccountsTrustedPublishersResponse>> CreateOrganizationsByNameServiceAccountsByServiceAccountIdTrustedPublishersAsResponseAsync(
            string name,
            string serviceAccountId,

            global::HuggingFace.CreateOrganizationsServiceAccountsTrustedPublishersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trusted publisher<br/>
        /// Let OIDC tokens matching the issuer and claims exchange for a short-lived token of the service account, with `resource` set to the service account name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="issuerUrl">
        /// URL of the OIDC issuer, e.g. `https://token.actions.githubusercontent.com`.
        /// </param>
        /// <param name="claims">
        /// Claims the OIDC token must match, by claim name. At least one is required.
        /// </param>
        /// <param name="capabilities">
        /// Scopes granted to matching tokens on top of `gated-repos` (read the gated repos the account has access to).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsServiceAccountsTrustedPublishersResponse> CreateOrganizationsByNameServiceAccountsByServiceAccountIdTrustedPublishersAsync(
            string name,
            string serviceAccountId,
            string issuerUrl,
            object claims,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTrustedPublishersRequestCapabilitie>? capabilities = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}