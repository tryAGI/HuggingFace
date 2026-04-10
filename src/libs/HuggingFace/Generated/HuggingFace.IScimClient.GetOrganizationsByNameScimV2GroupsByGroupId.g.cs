#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get a SCIM group<br/>
        /// Retrieves a group by its ID. If you provide the `excludedAttributes` parameter, the `members` attribute is not returned.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="groupId"></param>
        /// <param name="excludedAttributes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsScimV2GroupsResponse2> GetOrganizationsByNameScimV2GroupsByGroupIdAsync(
            string name,
            string groupId,
            string? excludedAttributes = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}