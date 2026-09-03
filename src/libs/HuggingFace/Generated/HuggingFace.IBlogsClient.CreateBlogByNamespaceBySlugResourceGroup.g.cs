#nullable enable

namespace HuggingFace
{
    public partial interface IBlogsClient
    {
        /// <summary>
        /// Set blog resource group<br/>
        /// Assign, move, or unassign an organization-owned blog to a resource group. Pass null to unassign. User-owned blogs are not eligible.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateBlogResourceGroupResponse> CreateBlogByNamespaceBySlugResourceGroupAsync(
            string @namespace,
            string slug,

            global::HuggingFace.CreateBlogResourceGroupRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set blog resource group<br/>
        /// Assign, move, or unassign an organization-owned blog to a resource group. Pass null to unassign. User-owned blogs are not eligible.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateBlogResourceGroupResponse>> CreateBlogByNamespaceBySlugResourceGroupAsResponseAsync(
            string @namespace,
            string slug,

            global::HuggingFace.CreateBlogResourceGroupRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set blog resource group<br/>
        /// Assign, move, or unassign an organization-owned blog to a resource group. Pass null to unassign. User-owned blogs are not eligible.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="resourceGroupId">
        /// The resource group to assign the blog to. If null, the blog is removed from any resource group.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateBlogResourceGroupResponse> CreateBlogByNamespaceBySlugResourceGroupAsync(
            string @namespace,
            string slug,
            string? resourceGroupId = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}