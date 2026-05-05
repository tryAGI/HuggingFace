#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user usage<br/>
        /// Get user usage for a given period
        /// </summary>
        /// <param name="periodId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetSettingsBillingUsageResponse> GetSettingsBillingUsageAsync(
            string? periodId = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user usage<br/>
        /// Get user usage for a given period
        /// </summary>
        /// <param name="periodId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetSettingsBillingUsageResponse>> GetSettingsBillingUsageAsResponseAsync(
            string? periodId = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}