#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Delete a SCIM group
        /// </summary>
        /// <param name="name"></param>
        /// <param name="groupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteOrganizationsByNameScimProvisioningV2GroupsByGroupIdAsync(
            string name,
            string groupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}