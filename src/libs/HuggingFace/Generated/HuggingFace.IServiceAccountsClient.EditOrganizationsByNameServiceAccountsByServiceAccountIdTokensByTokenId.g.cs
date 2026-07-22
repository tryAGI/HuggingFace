#nullable enable

namespace HuggingFace
{
    public partial interface IServiceAccountsClient
    {
        /// <summary>
        /// Update service-account token<br/>
        /// Update the name and/or permissions of an existing service account token.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="tokenId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsServiceAccountsTokensResponse> EditOrganizationsByNameServiceAccountsByServiceAccountIdTokensByTokenIdAsync(
            string name,
            string serviceAccountId,
            string tokenId,

            global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update service-account token<br/>
        /// Update the name and/or permissions of an existing service account token.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="tokenId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.PatchOrganizationsServiceAccountsTokensResponse>> EditOrganizationsByNameServiceAccountsByServiceAccountIdTokensByTokenIdAsResponseAsync(
            string name,
            string serviceAccountId,
            string tokenId,

            global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update service-account token<br/>
        /// Update the name and/or permissions of an existing service account token.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="tokenId"></param>
        /// <param name="displayName">
        /// New display name for the token
        /// </param>
        /// <param name="permissions">
        /// Org-wide permissions for this token
        /// </param>
        /// <param name="repoIds">
        /// Repositories to grant `repoPermissions` on. Can be repositories owned by the organization or any public repository. These override the org-wide permissions.
        /// </param>
        /// <param name="repoPermissions">
        /// Permissions granted on the selected `repoIds`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsServiceAccountsTokensResponse> EditOrganizationsByNameServiceAccountsByServiceAccountIdTokensByTokenIdAsync(
            string name,
            string serviceAccountId,
            string tokenId,
            string? displayName = default,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission>? permissions = default,
            global::System.Collections.Generic.IList<string>? repoIds = default,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission>? repoPermissions = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}