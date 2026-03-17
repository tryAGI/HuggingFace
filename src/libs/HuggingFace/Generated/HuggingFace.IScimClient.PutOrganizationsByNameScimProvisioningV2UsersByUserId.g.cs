#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Update a SCIM provisioning user<br/>
        /// Updates a provisioned user's invitation for non-managed organizations. User profile fields are not editable via SCIM for non-managed organizations.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response34> PutOrganizationsByNameScimProvisioningV2UsersByUserIdAsync(
            string name,
            string userId,

            global::HuggingFace.Request18 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a SCIM provisioning user<br/>
        /// Updates a provisioned user's invitation for non-managed organizations. User profile fields are not editable via SCIM for non-managed organizations.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="schemas"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="externalId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response34> PutOrganizationsByNameScimProvisioningV2UsersByUserIdAsync(
            string name,
            string userId,
            global::System.Collections.Generic.IList<string> schemas,
            string externalId,
            bool? active = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}