#nullable enable

namespace HuggingFace
{
    public partial interface ISqlConsoleClient
    {
        /// <summary>
        /// Update embed<br/>
        /// Update SQL Console embed
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchSqlConsoleEmbedResponse> EditByRepoTypeByNamespaceByRepoSqlConsoleEmbedByIdAsync(
            global::HuggingFace.PatchSqlConsoleEmbedRepoType repoType,
            string @namespace,
            string repo,
            string id,

            global::HuggingFace.PatchSqlConsoleEmbedRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update embed<br/>
        /// Update SQL Console embed
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.PatchSqlConsoleEmbedResponse>> EditByRepoTypeByNamespaceByRepoSqlConsoleEmbedByIdAsResponseAsync(
            global::HuggingFace.PatchSqlConsoleEmbedRepoType repoType,
            string @namespace,
            string repo,
            string id,

            global::HuggingFace.PatchSqlConsoleEmbedRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update embed<br/>
        /// Update SQL Console embed
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="private"></param>
        /// <param name="sql"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchSqlConsoleEmbedResponse> EditByRepoTypeByNamespaceByRepoSqlConsoleEmbedByIdAsync(
            global::HuggingFace.PatchSqlConsoleEmbedRepoType repoType,
            string @namespace,
            string repo,
            string id,
            string? title = default,
            bool? @private = default,
            string? sql = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}