#nullable enable

namespace HuggingFace
{
    public partial interface IContainersClient
    {
        /// <summary>
        /// Delete tag<br/>
        /// Deletes a single tag from a container image. The underlying image data is untouched.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="tag"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteContainersByNamespaceByRepoTagsByTagAsync(
            string @namespace,
            string repo,
            string tag,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete tag<br/>
        /// Deletes a single tag from a container image. The underlying image data is untouched.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="tag"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> DeleteContainersByNamespaceByRepoTagsByTagAsResponseAsync(
            string @namespace,
            string repo,
            string tag,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}