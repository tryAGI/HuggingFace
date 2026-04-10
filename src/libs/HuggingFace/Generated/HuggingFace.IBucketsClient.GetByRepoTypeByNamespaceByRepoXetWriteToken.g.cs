#nullable enable

namespace HuggingFace
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Xet write token<br/>
        /// Get a write short-lived access token for XET upload
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetXetWriteTokenResponse> GetByRepoTypeByNamespaceByRepoXetWriteTokenAsync(
            global::HuggingFace.GetXetWriteTokenRepoType repoType,
            string @namespace,
            string repo,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Xet write token<br/>
        /// Get a write short-lived access token for XET upload
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetXetWriteTokenResponse>> GetByRepoTypeByNamespaceByRepoXetWriteTokenAsResponseAsync(
            global::HuggingFace.GetXetWriteTokenRepoType repoType,
            string @namespace,
            string repo,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}