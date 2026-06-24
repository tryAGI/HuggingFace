#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Get ZeroGPU quota<br/>
        /// Get the authenticated user's current ZeroGPU quota usage and limits
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetSpacesZeroGpuQuotaResponse> GetSpacesZeroGpuQuotaAsync(
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get ZeroGPU quota<br/>
        /// Get the authenticated user's current ZeroGPU quota usage and limits
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetSpacesZeroGpuQuotaResponse>> GetSpacesZeroGpuQuotaAsResponseAsync(
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}