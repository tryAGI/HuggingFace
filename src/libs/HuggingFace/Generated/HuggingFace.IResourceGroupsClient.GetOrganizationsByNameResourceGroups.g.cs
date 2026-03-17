#nullable enable

namespace HuggingFace
{
    public partial interface IResourceGroupsClient
    {
        /// <summary>
        /// Get resource groups<br/>
        /// Retrieve accessible resource groups. Get all resource groups the user has access to.<br/>
        /// Requires the org to be Enterprise
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.ResponseItem3>> GetOrganizationsByNameResourceGroupsAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}