#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Check access<br/>
        /// Check if the user has access to jobs in the namespace
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="perms"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateJobsAuthCheckResponse> CreateJobsByNamespaceAuthCheckByPermsAsync(
            string @namespace,
            global::HuggingFace.CreateJobsAuthCheckPerms perms,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check access<br/>
        /// Check if the user has access to jobs in the namespace
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="perms"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateJobsAuthCheckResponse>> CreateJobsByNamespaceAuthCheckByPermsAsResponseAsync(
            string @namespace,
            global::HuggingFace.CreateJobsAuthCheckPerms perms,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}