#nullable enable

namespace HuggingFace
{
    public partial interface IResourceGroupsClient
    {
        /// <summary>
        /// Create a resource group<br/>
        /// Create a new resource group in the organization.<br/>
        /// Requires the org to be Enterprise
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response10> CreateOrganizationsByNameResourceGroupsAsync(
            string name,

            global::HuggingFace.Request8 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a resource group<br/>
        /// Create a new resource group in the organization.<br/>
        /// Requires the org to be Enterprise
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestName"></param>
        /// <param name="description"></param>
        /// <param name="users">
        /// Default Value: []
        /// </param>
        /// <param name="repos">
        /// Default Value: []
        /// </param>
        /// <param name="autoJoin"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response10> CreateOrganizationsByNameResourceGroupsAsync(
            string name,
            string requestName,
            string? description = default,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestUser>? users = default,
            global::System.Collections.Generic.IList<global::HuggingFace.RepoId>? repos = default,
            global::HuggingFace.AnyOf<global::HuggingFace.RequestAutoJoinVariant1, global::HuggingFace.RequestAutoJoinVariant2>? autoJoin = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}