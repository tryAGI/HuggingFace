#nullable enable

namespace HuggingFace
{
    public partial interface IResourceGroupsClient
    {
        /// <summary>
        /// Add users<br/>
        /// Add one or more organization members to a resource group.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponse> CreateOrganizationsByNameResourceGroupsByResourceGroupIdUsersAsync(
            string name,
            string resourceGroupId,

            global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add users<br/>
        /// Add one or more organization members to a resource group.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponse>> CreateOrganizationsByNameResourceGroupsByResourceGroupIdUsersAsResponseAsync(
            string name,
            string resourceGroupId,

            global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add users<br/>
        /// Add one or more organization members to a resource group.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="users"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponse> CreateOrganizationsByNameResourceGroupsByResourceGroupIdUsersAsync(
            string name,
            string resourceGroupId,
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant2>> users,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}