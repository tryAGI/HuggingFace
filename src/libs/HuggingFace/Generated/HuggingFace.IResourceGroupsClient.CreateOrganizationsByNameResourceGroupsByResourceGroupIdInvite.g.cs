#nullable enable

namespace HuggingFace
{
    public partial interface IResourceGroupsClient
    {
        /// <summary>
        /// Invite external user<br/>
        /// Invite a user who is not yet an organization member into a resource group. On accepting, they only get access to that resource group, with the requested read or write role.<br/>
        /// Requires external invites to be enabled in the organization's resource group settings, unless the caller is an organization admin.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponse> CreateOrganizationsByNameResourceGroupsByResourceGroupIdInviteAsync(
            string name,
            string resourceGroupId,

            global::HuggingFace.CreateOrganizationsResourceGroupsInviteRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invite external user<br/>
        /// Invite a user who is not yet an organization member into a resource group. On accepting, they only get access to that resource group, with the requested read or write role.<br/>
        /// Requires external invites to be enabled in the organization's resource group settings, unless the caller is an organization admin.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponse>> CreateOrganizationsByNameResourceGroupsByResourceGroupIdInviteAsResponseAsync(
            string name,
            string resourceGroupId,

            global::HuggingFace.CreateOrganizationsResourceGroupsInviteRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invite external user<br/>
        /// Invite a user who is not yet an organization member into a resource group. On accepting, they only get access to that resource group, with the requested read or write role.<br/>
        /// Requires external invites to be enabled in the organization's resource group settings, unless the caller is an organization admin.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="username">
        /// Username of an existing Hugging Face user
        /// </param>
        /// <param name="role">
        /// Role the invitee gets inside the resource group
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponse> CreateOrganizationsByNameResourceGroupsByResourceGroupIdInviteAsync(
            string name,
            string resourceGroupId,
            string username,
            global::HuggingFace.CreateOrganizationsResourceGroupsInviteRequestRole role,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}