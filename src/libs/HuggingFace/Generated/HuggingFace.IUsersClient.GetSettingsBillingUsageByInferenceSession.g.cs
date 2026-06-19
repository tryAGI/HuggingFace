#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user inference usage by session<br/>
        /// Get user inference-provider usage broken down per session id
        /// </summary>
        /// <param name="startDate">
        /// Default Value: 2026-06-01T00:00:00.000Z
        /// </param>
        /// <param name="endDate">
        /// Default Value: 2026-06-19T09:46:30.022Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponse> GetSettingsBillingUsageByInferenceSessionAsync(
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user inference usage by session<br/>
        /// Get user inference-provider usage broken down per session id
        /// </summary>
        /// <param name="startDate">
        /// Default Value: 2026-06-01T00:00:00.000Z
        /// </param>
        /// <param name="endDate">
        /// Default Value: 2026-06-19T09:46:30.022Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponse>> GetSettingsBillingUsageByInferenceSessionAsResponseAsync(
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}