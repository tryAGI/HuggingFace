#nullable enable

namespace HuggingFace
{
    public partial interface ISqlConsoleClient
    {
        /// <summary>
        /// Delete embed<br/>
        /// Delete SQL Console embed
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.DeleteSqlConsoleEmbedResponse> DeleteByRepoTypeByNamespaceByRepoSqlConsoleEmbedByIdAsync(
            global::HuggingFace.DeleteSqlConsoleEmbedRepoType repoType,
            string @namespace,
            string repo,
            string id,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete embed<br/>
        /// Delete SQL Console embed
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.DeleteSqlConsoleEmbedResponse>> DeleteByRepoTypeByNamespaceByRepoSqlConsoleEmbedByIdAsResponseAsync(
            global::HuggingFace.DeleteSqlConsoleEmbedRepoType repoType,
            string @namespace,
            string repo,
            string id,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}