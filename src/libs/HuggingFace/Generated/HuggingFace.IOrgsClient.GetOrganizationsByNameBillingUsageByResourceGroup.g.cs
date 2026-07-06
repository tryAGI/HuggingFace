#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get resource group usage<br/>
        /// Get org usage breakdown per resource group, returned as a time-series of monthly periods. Window is [startDate, endDate], defaults to the current month. Both dates must fall within the last 12 months. Storage values are the peak observed within each monthly period.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate">
        /// Default Value: 2026-07-01T00:00:00.000Z
        /// </param>
        /// <param name="endDate">
        /// Default Value: 2026-07-06T15:04:23.970Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponse> GetOrganizationsByNameBillingUsageByResourceGroupAsync(
            string name,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get resource group usage<br/>
        /// Get org usage breakdown per resource group, returned as a time-series of monthly periods. Window is [startDate, endDate], defaults to the current month. Both dates must fall within the last 12 months. Storage values are the peak observed within each monthly period.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate">
        /// Default Value: 2026-07-01T00:00:00.000Z
        /// </param>
        /// <param name="endDate">
        /// Default Value: 2026-07-06T15:04:23.970Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponse>> GetOrganizationsByNameBillingUsageByResourceGroupAsResponseAsync(
            string name,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}