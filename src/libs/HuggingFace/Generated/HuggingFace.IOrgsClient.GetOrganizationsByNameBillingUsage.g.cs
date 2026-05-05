#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get org usage<br/>
        /// Get org usage for a given period
        /// </summary>
        /// <param name="name"></param>
        /// <param name="periodId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsBillingUsageResponse> GetOrganizationsByNameBillingUsageAsync(
            string name,
            string? periodId = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get org usage<br/>
        /// Get org usage for a given period
        /// </summary>
        /// <param name="name"></param>
        /// <param name="periodId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetOrganizationsBillingUsageResponse>> GetOrganizationsByNameBillingUsageAsResponseAsync(
            string name,
            string? periodId = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}