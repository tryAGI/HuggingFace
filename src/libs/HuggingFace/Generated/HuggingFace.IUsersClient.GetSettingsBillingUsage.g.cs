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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response57> GetSettingsBillingUsageAsync(
            string? periodId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}