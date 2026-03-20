#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {

        /// <summary>
        /// Stream usage<br/>
        /// Get live usage for org
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetOrganizationsByNameBillingUsageLiveAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}