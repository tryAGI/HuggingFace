#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// List SCIM-managed users<br/>
        /// Retrieves a paginated list of organization members and pending invitations managed by SCIM for non-managed organizations.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startIndex">
        /// Default Value: 1
        /// </param>
        /// <param name="count">
        /// Default Value: 1000
        /// </param>
        /// <param name="filter">
        /// You can filter results using the equals operator (eq) to find items that match specific values like `id`, `userName`, `emails`, and `externalId`. For example, to find a user named Bob, use this search: `?filter=userName%20eq%20Bob`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponse> GetOrganizationsByNameScimProvisioningV2UsersAsync(
            string name,
            double? startIndex = default,
            double? count = default,
            string? filter = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}