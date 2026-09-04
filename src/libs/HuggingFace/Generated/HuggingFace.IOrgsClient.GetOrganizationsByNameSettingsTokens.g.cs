#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Member access tokens<br/>
        /// List the access tokens of the organization's members. Team or Enterprise only.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cursor">
        /// Pagination cursor from the `Link` header
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="q">
        /// Filter on `owner:`, `role:`, `status:` and `token:` (last 4 characters), negatable with `-`. Pass `status:all` to include revoked tokens.<br/>
        /// Default Value: -status:revoked
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItem>> GetOrganizationsByNameSettingsTokensAsync(
            string name,
            string? cursor = default,
            int? limit = default,
            string? q = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Member access tokens<br/>
        /// List the access tokens of the organization's members. Team or Enterprise only.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cursor">
        /// Pagination cursor from the `Link` header
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="q">
        /// Filter on `owner:`, `role:`, `status:` and `token:` (last 4 characters), negatable with `-`. Pass `status:all` to include revoked tokens.<br/>
        /// Default Value: -status:revoked
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItem>>> GetOrganizationsByNameSettingsTokensAsResponseAsync(
            string name,
            string? cursor = default,
            int? limit = default,
            string? q = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}