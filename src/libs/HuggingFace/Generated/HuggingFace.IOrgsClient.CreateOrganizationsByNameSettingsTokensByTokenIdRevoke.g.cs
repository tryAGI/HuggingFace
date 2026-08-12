#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Revoke member token<br/>
        /// An org admin can revoke a token's access to the org. The token itself isn't deleted, it still works outside the org. The token id is the one displayed in the org token settings page or through the tokens listing API endpoint. Enterprise only.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateOrganizationsByNameSettingsTokensByTokenIdRevokeAsync(
            string name,
            string tokenId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke member token<br/>
        /// An org admin can revoke a token's access to the org. The token itself isn't deleted, it still works outside the org. The token id is the one displayed in the org token settings page or through the tokens listing API endpoint. Enterprise only.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> CreateOrganizationsByNameSettingsTokensByTokenIdRevokeAsResponseAsync(
            string name,
            string tokenId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}