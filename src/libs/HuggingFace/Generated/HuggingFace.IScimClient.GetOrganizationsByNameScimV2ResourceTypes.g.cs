#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get SCIM Resource Types<br/>
        /// Returns the list of SCIM 2.0 resource types supported by this server (User and Group).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2ResourceTypesResponseItem>> GetOrganizationsByNameScimV2ResourceTypesAsync(
            string name,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get SCIM Resource Types<br/>
        /// Returns the list of SCIM 2.0 resource types supported by this server (User and Group).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2ResourceTypesResponseItem>>> GetOrganizationsByNameScimV2ResourceTypesAsResponseAsync(
            string name,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}