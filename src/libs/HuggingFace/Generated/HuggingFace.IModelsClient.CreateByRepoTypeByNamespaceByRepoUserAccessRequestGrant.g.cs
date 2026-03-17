#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Grant access<br/>
        /// Grant access to a user for a gated repository
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByRepoTypeByNamespaceByRepoUserAccessRequestGrantAsync(
            global::HuggingFace.RepoType56 repoType,
            string @namespace,
            string repo,

            global::HuggingFace.Request59 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Grant access<br/>
        /// Grant access to a user for a gated repository
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="userId"></param>
        /// <param name="user"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByRepoTypeByNamespaceByRepoUserAccessRequestGrantAsync(
            global::HuggingFace.RepoType56 repoType,
            string @namespace,
            string repo,
            string? userId = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}