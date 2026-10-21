#nullable enable

namespace HuggingFace
{
    public partial interface IResourceGroupsClient
    {
        /// <summary>
        /// Update resource group settings<br/>
        /// Update the org-wide resource group settings. Omitted fields are left unchanged.<br/>
        /// Enabling `allowExternalInvites` lets resource group admins add members to the org, consuming billable seats.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponse2> CreateOrganizationsByNameResourceGroupsSettingsAsync(
            string name,

            global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequest2 request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update resource group settings<br/>
        /// Update the org-wide resource group settings. Omitted fields are left unchanged.<br/>
        /// Enabling `allowExternalInvites` lets resource group admins add members to the org, consuming billable seats.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponse2>> CreateOrganizationsByNameResourceGroupsSettingsAsResponseAsync(
            string name,

            global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequest2 request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update resource group settings<br/>
        /// Update the org-wide resource group settings. Omitted fields are left unchanged.<br/>
        /// Enabling `allowExternalInvites` lets resource group admins add members to the org, consuming billable seats.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="minRoleToCreate">
        /// Minimum organization role required to create a resource group
        /// </param>
        /// <param name="allowExternalInvites">
        /// Whether resource group admins may invite users from outside the organization
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponse2> CreateOrganizationsByNameResourceGroupsSettingsAsync(
            string name,
            global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate? minRoleToCreate = default,
            string? allowExternalInvites = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}