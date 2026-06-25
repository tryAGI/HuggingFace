#nullable enable

namespace HuggingFace
{
    public partial interface IResourceGroupsClient
    {
        /// <summary>
        /// Change user role<br/>
        /// Change the role of a user in a resource group.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponse> EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsync(
            string name,
            string resourceGroupId,
            string username,

            global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change user role<br/>
        /// Change the role of a user in a resource group.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponse>> EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsResponseAsync(
            string name,
            string resourceGroupId,
            string username,

            global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change user role<br/>
        /// Change the role of a user in a resource group.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="username"></param>
        /// <param name="role"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponse> EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsync(
            string name,
            string resourceGroupId,
            string username,
            global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequestRole?, string> role,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}