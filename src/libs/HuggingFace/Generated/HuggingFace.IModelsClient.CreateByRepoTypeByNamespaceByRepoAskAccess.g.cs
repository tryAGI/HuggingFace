#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Request access<br/>
        /// Request access to a gated repository. The fields requested by repository card metadata (https://huggingface.co/docs/hub/en/models-gated#customize-requested-information)
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByRepoTypeByNamespaceByRepoAskAccessAsync(
            global::HuggingFace.RepoType51 repoType,
            string @namespace,
            string repo,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Request access<br/>
        /// Request access to a gated repository. The fields requested by repository card metadata (https://huggingface.co/docs/hub/en/models-gated#customize-requested-information)
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByRepoTypeByNamespaceByRepoAskAccessAsync(
            global::HuggingFace.RepoType51 repoType,
            string @namespace,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}