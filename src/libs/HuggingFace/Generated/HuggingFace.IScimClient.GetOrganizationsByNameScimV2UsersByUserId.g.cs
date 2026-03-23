#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get a SCIM user<br/>
        /// Retrieves a SCIM user by their ID.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsScimV2UsersResponse2> GetOrganizationsByNameScimV2UsersByUserIdAsync(
            string name,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}