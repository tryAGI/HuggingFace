#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List access requests<br/>
        /// List access requests for a gated repository
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="status"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.ResponseItem19>> GetByRepoTypeByNamespaceByRepoUserAccessRequestByStatusAsync(
            global::HuggingFace.RepoType54 repoType,
            string @namespace,
            string repo,
            global::HuggingFace.Status2 status,
            int? limit = default,
            global::System.DateTime? after = default,
            global::System.DateTime? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}