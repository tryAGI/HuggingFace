#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {

        /// <summary>
        /// Handle access request<br/>
        /// Handle a user's access request to a gated repository
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateModelsByNamespaceByRepoUserAccessRequestHandleAsync(
            string @namespace,
            string repo,

            global::HuggingFace.Request72 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Handle access request<br/>
        /// Handle a user's access request to a gated repository
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="userId">
        /// Either userId or user must be provided
        /// </param>
        /// <param name="user">
        /// Either userId or user must be provided
        /// </param>
        /// <param name="status"></param>
        /// <param name="rejectionReason"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateModelsByNamespaceByRepoUserAccessRequestHandleAsync(
            string @namespace,
            string repo,
            global::HuggingFace.RequestStatus2 status,
            string? userId = default,
            string? user = default,
            string? rejectionReason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}