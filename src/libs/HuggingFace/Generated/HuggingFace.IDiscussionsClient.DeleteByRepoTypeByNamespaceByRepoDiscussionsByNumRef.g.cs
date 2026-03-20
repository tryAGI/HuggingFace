#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {

        /// <summary>
        /// Delete PR ref<br/>
        /// Deletes the git ref for a closed/merged pull request to free up storage. LFS files unique to this PR will be garbage collected. The PR page and diff will still be viewable using stored commit data.
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefAsync(
            global::HuggingFace.RepoType18 repoType,
            string @namespace,
            string repo,
            string num,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}