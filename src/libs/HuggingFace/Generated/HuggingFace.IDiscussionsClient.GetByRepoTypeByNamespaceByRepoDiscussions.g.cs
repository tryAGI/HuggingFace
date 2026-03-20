#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {

        /// <summary>
        /// List discussions<br/>
        /// Get discussions for a repo
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="p">
        /// Default Value: 0
        /// </param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="status">
        /// Default Value: all
        /// </param>
        /// <param name="author"></param>
        /// <param name="search"></param>
        /// <param name="sort">
        /// Default Value: recently-created
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response104> GetByRepoTypeByNamespaceByRepoDiscussionsAsync(
            global::HuggingFace.RepoType9 repoType,
            string @namespace,
            string repo,
            int? p = default,
            global::HuggingFace.Type2? type = default,
            global::HuggingFace.Status? status = default,
            string? author = default,
            string? search = default,
            global::HuggingFace.Sort? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}