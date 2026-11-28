#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Assign resource group<br/>
        /// Assign, move, or unassign an organization-owned repository to a resource group. Pass null to unassign. User-owned repositories are not eligible.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateModelsResourceGroupResponse> CreateModelsByNamespaceByRepoResourceGroupAsync(
            string @namespace,
            string repo,

            global::HuggingFace.CreateModelsResourceGroupRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign resource group<br/>
        /// Assign, move, or unassign an organization-owned repository to a resource group. Pass null to unassign. User-owned repositories are not eligible.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateModelsResourceGroupResponse>> CreateModelsByNamespaceByRepoResourceGroupAsResponseAsync(
            string @namespace,
            string repo,

            global::HuggingFace.CreateModelsResourceGroupRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign resource group<br/>
        /// Assign, move, or unassign an organization-owned repository to a resource group. Pass null to unassign. User-owned repositories are not eligible.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="resourceGroupId">
        /// The resource group to assign the repository to. If null, the repository is removed from any resource group.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateModelsResourceGroupResponse> CreateModelsByNamespaceByRepoResourceGroupAsync(
            string @namespace,
            string repo,
            string? resourceGroupId = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}