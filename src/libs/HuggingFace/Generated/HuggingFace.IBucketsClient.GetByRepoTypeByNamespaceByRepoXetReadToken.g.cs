#nullable enable

namespace HuggingFace
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Xet read token<br/>
        /// Get a read short-lived access token for XET
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetXetReadTokenResponse> GetByRepoTypeByNamespaceByRepoXetReadTokenAsync(
            global::HuggingFace.GetXetReadTokenRepoType repoType,
            string @namespace,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Xet read token<br/>
        /// Get a read short-lived access token for XET
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetXetReadTokenResponse>> GetByRepoTypeByNamespaceByRepoXetReadTokenAsResponseAsync(
            global::HuggingFace.GetXetReadTokenRepoType repoType,
            string @namespace,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}