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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsBillingUsageResponse> GetOrganizationsByNameBillingUsageAsync(
            string name,
            string? periodId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}