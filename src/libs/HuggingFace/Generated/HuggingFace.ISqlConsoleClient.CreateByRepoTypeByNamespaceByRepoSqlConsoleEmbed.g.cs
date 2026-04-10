#nullable enable

namespace HuggingFace
{
    public partial interface ISqlConsoleClient
    {
        /// <summary>
        /// Create embed<br/>
        /// Create SQL Console embed
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSqlConsoleEmbedResponse> CreateByRepoTypeByNamespaceByRepoSqlConsoleEmbedAsync(
            global::HuggingFace.CreateSqlConsoleEmbedRepoType repoType,
            string @namespace,
            string repo,

            global::HuggingFace.CreateSqlConsoleEmbedRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create embed<br/>
        /// Create SQL Console embed
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="sql"></param>
        /// <param name="title"></param>
        /// <param name="private"></param>
        /// <param name="views"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSqlConsoleEmbedResponse> CreateByRepoTypeByNamespaceByRepoSqlConsoleEmbedAsync(
            global::HuggingFace.CreateSqlConsoleEmbedRepoType repoType,
            string @namespace,
            string repo,
            string sql,
            string title,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSqlConsoleEmbedRequestView> views,
            bool? @private = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}