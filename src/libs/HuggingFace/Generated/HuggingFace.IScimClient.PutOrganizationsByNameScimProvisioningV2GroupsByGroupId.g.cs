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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponse> PutOrganizationsByNameScimProvisioningV2GroupsByGroupIdAsync(
            string name,
            string groupId,

            global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a SCIM group<br/>
        /// Updates a group by its ID. The group name must be unique within the organization.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponse>> PutOrganizationsByNameScimProvisioningV2GroupsByGroupIdAsResponseAsync(
            string name,
            string groupId,

            global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponse> PutOrganizationsByNameScimProvisioningV2GroupsByGroupIdAsync(
            string name,
            string groupId,
            global::System.Collections.Generic.IList<string> schemas,
            string displayName,
            global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsRequestMember> members,
            string? externalId = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}