#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Create a SCIM user<br/>
        /// Creates a new user in the organization. If the user already exists, only `active` field will be updated to provision the user.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsScimV2UsersResponse> CreateOrganizationsByNameScimV2UsersAsync(
            string name,

            global::HuggingFace.CreateOrganizationsScimV2UsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a SCIM user<br/>
        /// Creates a new user in the organization. If the user already exists, only `active` field will be updated to provision the user.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="schemas"></param>
        /// <param name="userName">
        /// Username for the user, it should respect the hub rules: No consecutive dashes, No digit-only, Does not start or end with a dash, Only dashes, letters or numbers, Not 24 chars hex string
        /// </param>
        /// <param name="emails"></param>
        /// <param name="requestName"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="externalId">
        /// External ID for the user, it must be unique within the organization and is required for managed users
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsScimV2UsersResponse> CreateOrganizationsByNameScimV2UsersAsync(
            string name,
            global::System.Collections.Generic.IList<string> schemas,
            string userName,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2UsersRequestEmail> emails,
            global::HuggingFace.CreateOrganizationsScimV2UsersRequestName requestName,
            string externalId,
            bool? active = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}