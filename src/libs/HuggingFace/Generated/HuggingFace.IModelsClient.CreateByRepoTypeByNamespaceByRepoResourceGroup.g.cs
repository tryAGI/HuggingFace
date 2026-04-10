#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Add resource group<br/>
        /// Add the repository to a resource group
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateResourceGroupResponse> CreateByRepoTypeByNamespaceByRepoResourceGroupAsync(
            global::HuggingFace.CreateResourceGroupRepoType repoType,
            string @namespace,
            string repo,

            global::HuggingFace.CreateResourceGroupRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add resource group<br/>
        /// Add the repository to a resource group
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="resourceGroupId">
        /// The resource group to add the repository to, if null, the repository will be removed from the resource group
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateResourceGroupResponse> CreateByRepoTypeByNamespaceByRepoResourceGroupAsync(
            global::HuggingFace.CreateResourceGroupRepoType repoType,
            string @namespace,
            string repo,
            string? resourceGroupId = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}