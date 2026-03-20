#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {

        /// <summary>
        /// Stream usage<br/>
        /// Get live usage for user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetUsersByUsernameBillingUsageLiveAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}