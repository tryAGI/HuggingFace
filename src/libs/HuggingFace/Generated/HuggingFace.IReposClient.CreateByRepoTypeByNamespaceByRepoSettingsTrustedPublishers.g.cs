#nullable enable

namespace HuggingFace
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Repo trusted publisher<br/>
        /// Let OIDC tokens matching the issuer and claims exchange for a short-lived token on the repo. Requires write access to the repo.
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSettingsTrustedPublishersResponse> CreateByRepoTypeByNamespaceByRepoSettingsTrustedPublishersAsync(
            global::HuggingFace.CreateSettingsTrustedPublishersRepoType repoType,
            string @namespace,
            string repo,

            global::HuggingFace.CreateSettingsTrustedPublishersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Repo trusted publisher<br/>
        /// Let OIDC tokens matching the issuer and claims exchange for a short-lived token on the repo. Requires write access to the repo.
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateSettingsTrustedPublishersResponse>> CreateByRepoTypeByNamespaceByRepoSettingsTrustedPublishersAsResponseAsync(
            global::HuggingFace.CreateSettingsTrustedPublishersRepoType repoType,
            string @namespace,
            string repo,

            global::HuggingFace.CreateSettingsTrustedPublishersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Repo trusted publisher<br/>
        /// Let OIDC tokens matching the issuer and claims exchange for a short-lived token on the repo. Requires write access to the repo.
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="issuerUrl">
        /// URL of the OIDC issuer, e.g. `https://token.actions.githubusercontent.com`.
        /// </param>
        /// <param name="claims">
        /// Claims the OIDC token must match, by claim name. At least one is required.
        /// </param>
        /// <param name="permissions">
        /// Permissions granted on the repo to matching tokens. Defaults to `["repo.content.write"]`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSettingsTrustedPublishersResponse> CreateByRepoTypeByNamespaceByRepoSettingsTrustedPublishersAsync(
            global::HuggingFace.CreateSettingsTrustedPublishersRepoType repoType,
            string @namespace,
            string repo,
            string issuerUrl,
            object claims,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsTrustedPublishersRequestPermission>? permissions = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}