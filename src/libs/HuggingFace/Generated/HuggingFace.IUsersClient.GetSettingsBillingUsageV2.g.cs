#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user usage<br/>
        /// Get user usage for a given period
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetSettingsBillingUsageV2Async(
            int startDate,
            int endDate,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}