#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Cancel access request<br/>
        /// Cancel the current user's access request to a gated repository
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateModelsByNamespaceByRepoUserAccessRequestCancelAsync(
            string @namespace,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}