#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Inference usage<br/>
        /// Get org inference-provider usage per member, model and provider, returned as a time-series of daily periods. Window is [startDate, endDate], defaults to the current month. Both dates must fall within the last 12 months. Returns up to `limit` periods, follow the `Link` header for the next ones. Requests are included up to 2 hours after they are made.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate">
        /// Default Value: 2026-10-01T00:00:00.000Z
        /// </param>
        /// <param name="endDate">
        /// Default Value: 2026-10-08T15:50:27.709Z
        /// </param>
        /// <param name="limit">
        /// Number of daily periods per page<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageInferenceResponseItem>> GetOrganizationsByNameBillingUsageInferenceAsync(
            string name,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            int? limit = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inference usage<br/>
        /// Get org inference-provider usage per member, model and provider, returned as a time-series of daily periods. Window is [startDate, endDate], defaults to the current month. Both dates must fall within the last 12 months. Returns up to `limit` periods, follow the `Link` header for the next ones. Requests are included up to 2 hours after they are made.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate">
        /// Default Value: 2026-10-01T00:00:00.000Z
        /// </param>
        /// <param name="endDate">
        /// Default Value: 2026-10-08T15:50:27.709Z
        /// </param>
        /// <param name="limit">
        /// Number of daily periods per page<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageInferenceResponseItem>>> GetOrganizationsByNameBillingUsageInferenceAsResponseAsync(
            string name,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            int? limit = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}