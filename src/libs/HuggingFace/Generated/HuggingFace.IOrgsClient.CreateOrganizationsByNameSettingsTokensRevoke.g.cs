#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Revoke a member's access token from the organization<br/>
        /// An org admin can revoke a token's access to the org. The token itself isn't deleted, it still works outside the org. Requires the raw token value. Enterprise only.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateOrganizationsByNameSettingsTokensRevokeAsync(
            string name,

            global::HuggingFace.Request7 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Revoke a member's access token from the organization<br/>
        /// An org admin can revoke a token's access to the org. The token itself isn't deleted, it still works outside the org. Requires the raw token value. Enterprise only.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateOrganizationsByNameSettingsTokensRevokeAsync(
            string name,
            string token,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}