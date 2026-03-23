#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Update SCIM group<br/>
        /// Update attributes of a SCIM group. Updates individual attributes using Operations format. Just provide the changes you want to make using add, remove (only `members` is supported), or replace operations.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponse> EditOrganizationsByNameScimProvisioningV2GroupsByGroupIdAsync(
            string name,
            string groupId,

            global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update SCIM group<br/>
        /// Update attributes of a SCIM group. Updates individual attributes using Operations format. Just provide the changes you want to make using add, remove (only `members` is supported), or replace operations.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="groupId"></param>
        /// <param name="schemas"></param>
        /// <param name="operations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponse> EditOrganizationsByNameScimProvisioningV2GroupsByGroupIdAsync(
            string name,
            string groupId,
            global::System.Collections.Generic.IList<string> schemas,
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant1, global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant2>> operations,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}