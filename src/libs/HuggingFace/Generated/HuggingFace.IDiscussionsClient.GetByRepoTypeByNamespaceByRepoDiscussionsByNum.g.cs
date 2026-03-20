#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {

        /// <summary>
        /// Get discussion details
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AllOf<global::HuggingFace.AnyOf<global::HuggingFace.ResponseVariant15, global::HuggingFace.ResponseVariant24>?, global::HuggingFace.Response107>> GetByRepoTypeByNamespaceByRepoDiscussionsByNumAsync(
            global::HuggingFace.RepoType11 repoType,
            string @namespace,
            string repo,
            string num,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}