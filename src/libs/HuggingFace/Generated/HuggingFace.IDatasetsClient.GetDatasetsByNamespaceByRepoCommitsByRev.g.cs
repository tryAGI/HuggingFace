#nullable enable

namespace HuggingFace
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List commits
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="p">
        /// Default Value: 0
        /// </param>
        /// <param name="expand"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsCommitsResponseItem>> GetDatasetsByNamespaceByRepoCommitsByRevAsync(
            string @namespace,
            string repo,
            string rev,
            int? p = default,
            global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsCommitsExpandItem>? expand = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List commits
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="p">
        /// Default Value: 0
        /// </param>
        /// <param name="expand"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsCommitsResponseItem>>> GetDatasetsByNamespaceByRepoCommitsByRevAsResponseAsync(
            string @namespace,
            string repo,
            string rev,
            int? p = default,
            global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsCommitsExpandItem>? expand = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}