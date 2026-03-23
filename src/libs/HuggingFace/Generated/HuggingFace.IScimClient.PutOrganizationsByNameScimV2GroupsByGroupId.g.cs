#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Update a SCIM group<br/>
        /// Updates a group by its ID. The group name must be unique within the organization.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PutOrganizationsScimV2GroupsResponse> PutOrganizationsByNameScimV2GroupsByGroupIdAsync(
            string name,
            string groupId,

            global::HuggingFace.PutOrganizationsScimV2GroupsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a SCIM group<br/>
        /// Updates a group by its ID. The group name must be unique within the organization.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="groupId"></param>
        /// <param name="schemas"></param>
        /// <param name="displayName"></param>
        /// <param name="externalId"></param>
        /// <param name="members"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PutOrganizationsScimV2GroupsResponse> PutOrganizationsByNameScimV2GroupsByGroupIdAsync(
            string name,
            string groupId,
            global::System.Collections.Generic.IList<string> schemas,
            string displayName,
            global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2GroupsRequestMember> members,
            string? externalId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}