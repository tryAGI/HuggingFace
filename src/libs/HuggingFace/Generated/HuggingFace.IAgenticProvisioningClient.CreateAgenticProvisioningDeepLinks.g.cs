#nullable enable

namespace HuggingFace
{
    public partial interface IAgenticProvisioningClient
    {
        /// <summary>
        /// Create a self-authenticated deep link to the user's billing dashboard
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateAgenticProvisioningDeepLinksResponse> CreateAgenticProvisioningDeepLinksAsync(

            global::HuggingFace.CreateAgenticProvisioningDeepLinksRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a self-authenticated deep link to the user's billing dashboard
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateAgenticProvisioningDeepLinksResponse>> CreateAgenticProvisioningDeepLinksAsResponseAsync(

            global::HuggingFace.CreateAgenticProvisioningDeepLinksRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a self-authenticated deep link to the user's billing dashboard
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateAgenticProvisioningDeepLinksResponse> CreateAgenticProvisioningDeepLinksAsync(
            string purpose = "dashboard",
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}