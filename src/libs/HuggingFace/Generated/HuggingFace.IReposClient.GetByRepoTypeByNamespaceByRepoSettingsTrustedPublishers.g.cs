#nullable enable

namespace HuggingFace
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Repo trusted publishers<br/>
        /// List the [trusted publishers](https://huggingface.co/docs/hub/trusted-publishers) of a repo.
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsTrustedPublishersResponseItem>> GetByRepoTypeByNamespaceByRepoSettingsTrustedPublishersAsync(
            global::HuggingFace.GetSettingsTrustedPublishersRepoType repoType,
            string @namespace,
            string repo,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Repo trusted publishers<br/>
        /// List the [trusted publishers](https://huggingface.co/docs/hub/trusted-publishers) of a repo.
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsTrustedPublishersResponseItem>>> GetByRepoTypeByNamespaceByRepoSettingsTrustedPublishersAsResponseAsync(
            global::HuggingFace.GetSettingsTrustedPublishersRepoType repoType,
            string @namespace,
            string repo,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}