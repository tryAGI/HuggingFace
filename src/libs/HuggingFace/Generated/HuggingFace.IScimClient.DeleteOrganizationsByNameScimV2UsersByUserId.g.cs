#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {

        /// <summary>
        /// Delete a SCIM user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteOrganizationsByNameScimV2UsersByUserIdAsync(
            string name,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}