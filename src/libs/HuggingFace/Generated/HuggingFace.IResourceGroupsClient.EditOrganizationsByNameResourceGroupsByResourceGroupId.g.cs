#nullable enable

namespace HuggingFace
{
    public partial interface IResourceGroupsClient
    {
        /// <summary>
        /// Update resource group<br/>
        /// Update the name, description and/or monthly spend limits (in cents, `null` to remove) of a resource group.<br/>
        /// `spendLimits.total` caps the group's combined spend across every product; the per-product limits cap each product on top of it.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsResourceGroupsResponse> EditOrganizationsByNameResourceGroupsByResourceGroupIdAsync(
            string name,
            string resourceGroupId,

            global::HuggingFace.PatchOrganizationsResourceGroupsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update resource group<br/>
        /// Update the name, description and/or monthly spend limits (in cents, `null` to remove) of a resource group.<br/>
        /// `spendLimits.total` caps the group's combined spend across every product; the per-product limits cap each product on top of it.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.PatchOrganizationsResourceGroupsResponse>> EditOrganizationsByNameResourceGroupsByResourceGroupIdAsResponseAsync(
            string name,
            string resourceGroupId,

            global::HuggingFace.PatchOrganizationsResourceGroupsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update resource group<br/>
        /// Update the name, description and/or monthly spend limits (in cents, `null` to remove) of a resource group.<br/>
        /// `spendLimits.total` caps the group's combined spend across every product; the per-product limits cap each product on top of it.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="requestName"></param>
        /// <param name="description"></param>
        /// <param name="spendLimits"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsResourceGroupsResponse> EditOrganizationsByNameResourceGroupsByResourceGroupIdAsync(
            string name,
            string resourceGroupId,
            string? requestName = default,
            string? description = default,
            global::HuggingFace.PatchOrganizationsResourceGroupsRequestSpendLimits? spendLimits = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}