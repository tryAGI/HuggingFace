#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Delete a SCIM provisioning user<br/>
        /// Removes a user from the organization and deletes any pending invitations for non-managed organizations.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteOrganizationsByNameScimProvisioningV2UsersByUserIdAsync(
            string name,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}