#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get session inference usage<br/>
        /// Get org inference-provider usage broken down per session id, as a time-series of monthly periods.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate">
        /// Default Value: 2026-07-01T00:00:00.000Z
        /// </param>
        /// <param name="endDate">
        /// Default Value: 2026-07-15T10:59:59.046Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponse> GetOrganizationsByNameBillingUsageByInferenceSessionAsync(
            string name,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get session inference usage<br/>
        /// Get org inference-provider usage broken down per session id, as a time-series of monthly periods.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate">
        /// Default Value: 2026-07-01T00:00:00.000Z
        /// </param>
        /// <param name="endDate">
        /// Default Value: 2026-07-15T10:59:59.046Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponse>> GetOrganizationsByNameBillingUsageByInferenceSessionAsResponseAsync(
            string name,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}