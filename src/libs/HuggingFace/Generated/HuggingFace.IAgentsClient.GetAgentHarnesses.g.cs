#nullable enable

namespace HuggingFace
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get agent harnesses<br/>
        /// Get the registry of AI agents / harnesses known to the Hub, along with the standard environment variables used to detect them. Clients use this registry to identify which agent they are running in when reporting Hub activity.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetAgentHarnessesResponse> GetAgentHarnessesAsync(
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get agent harnesses<br/>
        /// Get the registry of AI agents / harnesses known to the Hub, along with the standard environment variables used to detect them. Clients use this registry to identify which agent they are running in when reporting Hub activity.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetAgentHarnessesResponse>> GetAgentHarnessesAsResponseAsync(
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}