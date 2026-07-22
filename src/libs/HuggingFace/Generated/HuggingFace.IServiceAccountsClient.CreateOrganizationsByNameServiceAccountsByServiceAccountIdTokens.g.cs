#nullable enable

namespace HuggingFace
{
    public partial interface IServiceAccountsClient
    {
        /// <summary>
        /// Create service-account token<br/>
        /// Create a new access token for a service account. Store the token securely - it cannot be retrieved later.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsServiceAccountsTokensResponse> CreateOrganizationsByNameServiceAccountsByServiceAccountIdTokensAsync(
            string name,
            string serviceAccountId,

            global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create service-account token<br/>
        /// Create a new access token for a service account. Store the token securely - it cannot be retrieved later.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateOrganizationsServiceAccountsTokensResponse>> CreateOrganizationsByNameServiceAccountsByServiceAccountIdTokensAsResponseAsync(
            string name,
            string serviceAccountId,

            global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create service-account token<br/>
        /// Create a new access token for a service account. Store the token securely - it cannot be retrieved later.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="displayName">
        /// Display name for the token<br/>
        /// Default Value: API Token
        /// </param>
        /// <param name="permissions">
        /// Org-wide permissions for this token<br/>
        /// Default Value: []
        /// </param>
        /// <param name="repoIds">
        /// Repositories to grant `repoPermissions` on. Can be repositories owned by the organization or any public repository. These override the org-wide permissions.
        /// </param>
        /// <param name="repoPermissions">
        /// Permissions granted on the selected `repoIds`.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsServiceAccountsTokensResponse> CreateOrganizationsByNameServiceAccountsByServiceAccountIdTokensAsync(
            string name,
            string serviceAccountId,
            string? displayName = default,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission>? permissions = default,
            global::System.Collections.Generic.IList<string>? repoIds = default,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission>? repoPermissions = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}