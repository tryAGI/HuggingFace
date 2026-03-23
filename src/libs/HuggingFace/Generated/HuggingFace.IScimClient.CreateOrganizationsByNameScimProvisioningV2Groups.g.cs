#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Create a SCIM group<br/>
        /// Creates a new group in the organization. The group name must be unique within the organization.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponse> CreateOrganizationsByNameScimProvisioningV2GroupsAsync(
            string name,

            global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a SCIM group<br/>
        /// Creates a new group in the organization. The group name must be unique within the organization.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
        /// <param name="externalId"></param>
        /// <param name="members">
        /// Array of SCIM user ids
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponse> CreateOrganizationsByNameScimProvisioningV2GroupsAsync(
            string name,
            string displayName,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsRequestMember> members,
            string? externalId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}