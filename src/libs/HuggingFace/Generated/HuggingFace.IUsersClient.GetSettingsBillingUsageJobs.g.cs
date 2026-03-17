#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get jobs usage<br/>
        /// Get user Jobs usage for current subscription period
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response58> GetSettingsBillingUsageJobsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}