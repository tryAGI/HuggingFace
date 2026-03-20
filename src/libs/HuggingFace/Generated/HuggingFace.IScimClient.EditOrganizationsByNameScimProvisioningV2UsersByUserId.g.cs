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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response33> EditOrganizationsByNameScimProvisioningV2UsersByUserIdAsync(
            string name,
            string userId,

            global::HuggingFace.Request17 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an attribute of a SCIM provisioning user<br/>
        /// Modify individual attributes for non-managed organizations. Only the `active` field can be modified. User profile fields are not editable via SCIM.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="schemas"></param>
        /// <param name="operations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response33> EditOrganizationsByNameScimProvisioningV2UsersByUserIdAsync(
            string name,
            string userId,
            global::System.Collections.Generic.IList<string> schemas,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestOperation2> operations,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}