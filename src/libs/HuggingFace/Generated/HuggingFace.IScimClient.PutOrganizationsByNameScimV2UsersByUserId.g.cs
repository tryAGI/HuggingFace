#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Update a SCIM user<br/>
        /// Updates a provisioned user, you'll need to provide all their information fresh - just like setting them up for the first time. Any details you don't include will be automatically removed, so make sure to include everything they need to keep their account running smoothly. Setting `active` to `false` will deprovision the user from the organization.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PutOrganizationsScimV2UsersResponse> PutOrganizationsByNameScimV2UsersByUserIdAsync(
            string name,
            string userId,

            global::HuggingFace.PutOrganizationsScimV2UsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a SCIM user<br/>
        /// Updates a provisioned user, you'll need to provide all their information fresh - just like setting them up for the first time. Any details you don't include will be automatically removed, so make sure to include everything they need to keep their account running smoothly. Setting `active` to `false` will deprovision the user from the organization.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="schemas"></param>
        /// <param name="userName">
        /// Username for the user, it should respect the hub rules: No consecutive dashes, No digit-only, Does not start or end with a dash, Only dashes, letters or numbers, Not 24 chars hex string
        /// </param>
        /// <param name="emails"></param>
        /// <param name="requestName"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="externalId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PutOrganizationsScimV2UsersResponse> PutOrganizationsByNameScimV2UsersByUserIdAsync(
            string name,
            string userId,
            global::System.Collections.Generic.IList<string> schemas,
            string userName,
            global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2UsersRequestEmail> emails,
            global::HuggingFace.PutOrganizationsScimV2UsersRequestName requestName,
            string externalId,
            bool? active = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}