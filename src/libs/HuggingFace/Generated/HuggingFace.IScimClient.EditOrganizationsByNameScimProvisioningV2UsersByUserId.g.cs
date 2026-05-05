#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Update an attribute of a SCIM provisioning user<br/>
        /// Modify individual attributes for non-managed organizations. Only the `active` field can be modified. User profile fields are not editable via SCIM.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponse> EditOrganizationsByNameScimProvisioningV2UsersByUserIdAsync(
            string name,
            string userId,

            global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an attribute of a SCIM provisioning user<br/>
        /// Modify individual attributes for non-managed organizations. Only the `active` field can be modified. User profile fields are not editable via SCIM.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponse>> EditOrganizationsByNameScimProvisioningV2UsersByUserIdAsResponseAsync(
            string name,
            string userId,

            global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an attribute of a SCIM provisioning user<br/>
        /// Modify individual attributes for non-managed organizations. Only the `active` field can be modified. User profile fields are not editable via SCIM.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="schemas"></param>
        /// <param name="operations"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponse> EditOrganizationsByNameScimProvisioningV2UsersByUserIdAsync(
            string name,
            string userId,
            global::System.Collections.Generic.IList<string> schemas,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperation> operations,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}