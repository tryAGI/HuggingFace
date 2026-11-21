#nullable enable

namespace HuggingFace
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Repo trusted publisher
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="publisherId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByRepoTypeByNamespaceByRepoSettingsTrustedPublishersByPublisherIdAsync(
            global::HuggingFace.DeleteSettingsTrustedPublishersRepoType repoType,
            string @namespace,
            string repo,
            string publisherId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Repo trusted publisher
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="publisherId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> DeleteByRepoTypeByNamespaceByRepoSettingsTrustedPublishersByPublisherIdAsResponseAsync(
            global::HuggingFace.DeleteSettingsTrustedPublishersRepoType repoType,
            string @namespace,
            string repo,
            string publisherId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}