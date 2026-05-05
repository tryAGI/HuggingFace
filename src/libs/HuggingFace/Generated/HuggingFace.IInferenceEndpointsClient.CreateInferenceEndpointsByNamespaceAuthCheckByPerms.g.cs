#nullable enable

namespace HuggingFace
{
    public partial interface IInferenceEndpointsClient
    {
        /// <summary>
        /// Check access<br/>
        /// Check if the user has access to the inference endpoint
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="perms"></param>
        /// <param name="own"></param>
        /// <param name="isCreator"></param>
        /// <param name="creatorId"></param>
        /// <param name="incurCost"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="repoId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateInferenceEndpointsAuthCheckResponse> CreateInferenceEndpointsByNamespaceAuthCheckByPermsAsync(
            string @namespace,
            global::HuggingFace.CreateInferenceEndpointsAuthCheckPerms perms,
            object? own = default,
            object? isCreator = default,
            string? creatorId = default,
            object? incurCost = default,
            string? resourceGroupId = default,
            string? repoId = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check access<br/>
        /// Check if the user has access to the inference endpoint
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="perms"></param>
        /// <param name="own"></param>
        /// <param name="isCreator"></param>
        /// <param name="creatorId"></param>
        /// <param name="incurCost"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="repoId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateInferenceEndpointsAuthCheckResponse>> CreateInferenceEndpointsByNamespaceAuthCheckByPermsAsResponseAsync(
            string @namespace,
            global::HuggingFace.CreateInferenceEndpointsAuthCheckPerms perms,
            object? own = default,
            object? isCreator = default,
            string? creatorId = default,
            object? incurCost = default,
            string? resourceGroupId = default,
            string? repoId = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}