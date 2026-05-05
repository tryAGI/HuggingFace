#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// List SCIM groups<br/>
        /// Get a list of SCIM groups. Retrieves a paginated list of all organization groups. If you provide the filter parameter, the resources for all matching groups are returned.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startIndex">
        /// Default Value: 1
        /// </param>
        /// <param name="count">
        /// Default Value: 1000
        /// </param>
        /// <param name="filter"></param>
        /// <param name="excludedAttributes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponse> GetOrganizationsByNameScimProvisioningV2GroupsAsync(
            string name,
            double? startIndex = default,
            double? count = default,
            string? filter = default,
            string? excludedAttributes = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List SCIM groups<br/>
        /// Get a list of SCIM groups. Retrieves a paginated list of all organization groups. If you provide the filter parameter, the resources for all matching groups are returned.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startIndex">
        /// Default Value: 1
        /// </param>
        /// <param name="count">
        /// Default Value: 1000
        /// </param>
        /// <param name="filter"></param>
        /// <param name="excludedAttributes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponse>> GetOrganizationsByNameScimProvisioningV2GroupsAsResponseAsync(
            string name,
            double? startIndex = default,
            double? count = default,
            string? filter = default,
            string? excludedAttributes = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}