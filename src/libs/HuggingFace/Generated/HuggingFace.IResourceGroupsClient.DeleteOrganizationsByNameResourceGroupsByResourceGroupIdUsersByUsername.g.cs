#nullable enable

namespace HuggingFace
{
    public partial interface IResourceGroupsClient
    {
        /// <summary>
        /// Remove user<br/>
        /// Remove a user from a resource group, revoking the access granted through it.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponse> DeleteOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsync(
            string name,
            string resourceGroupId,
            string username,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove user<br/>
        /// Remove a user from a resource group, revoking the access granted through it.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponse>> DeleteOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsResponseAsync(
            string name,
            string resourceGroupId,
            string username,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}