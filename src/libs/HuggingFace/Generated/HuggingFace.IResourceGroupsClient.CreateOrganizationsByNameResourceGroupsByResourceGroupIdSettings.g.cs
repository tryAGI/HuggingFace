#nullable enable

namespace HuggingFace
{
    public partial interface IResourceGroupsClient
    {
        /// <summary>
        /// Configure auto-join<br/>
        /// Configure the auto-join settings of a resource group.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponse> CreateOrganizationsByNameResourceGroupsByResourceGroupIdSettingsAsync(
            string name,
            string resourceGroupId,

            global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure auto-join<br/>
        /// Configure the auto-join settings of a resource group.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponse>> CreateOrganizationsByNameResourceGroupsByResourceGroupIdSettingsAsResponseAsync(
            string name,
            string resourceGroupId,

            global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure auto-join<br/>
        /// Configure the auto-join settings of a resource group.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="autoJoin"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponse> CreateOrganizationsByNameResourceGroupsByResourceGroupIdSettingsAsync(
            string name,
            string resourceGroupId,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant2>? autoJoin = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}