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
        global::System.Threading.Tasks.Task<global::HuggingFace.AllOf<global::HuggingFace.AnyOf<global::HuggingFace.ResponseVariant13, global::HuggingFace.ResponseVariant22>?, global::HuggingFace.Response85>> GetByRepoTypeByNamespaceByRepoDiscussionsByNumAsync(
            global::HuggingFace.RepoType29 repoType,
            string @namespace,
            string repo,
            string num,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}