#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get a SCIM provisioning user<br/>
        /// Retrieves a SCIM user by their ID for non-managed organizations.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponse2> GetOrganizationsByNameScimProvisioningV2UsersByUserIdAsync(
            string name,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}