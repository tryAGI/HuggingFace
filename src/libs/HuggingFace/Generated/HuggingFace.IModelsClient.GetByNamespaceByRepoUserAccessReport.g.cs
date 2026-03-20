#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {

        /// <summary>
        /// Export access report<br/>
        /// Export a report of all access requests for a gated repository
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetByNamespaceByRepoUserAccessReportAsync(
            string @namespace,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}